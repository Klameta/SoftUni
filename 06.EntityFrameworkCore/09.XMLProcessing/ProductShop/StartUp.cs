using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            ProductShopContext productShopContext = new ProductShopContext();
            /*productShopContext.Database.EnsureDeleted();
            productShopContext.Database.EnsureCreated();

            ImportUsers(productShopContext, File.ReadAllText(@"../../../Datasets/users.xml"));
            ImportProducts(productShopContext, File.ReadAllText(@"../../../Datasets/products.xml"));
            ImportCategories(productShopContext, File.ReadAllText(@"../../../Datasets/categories.xml"));

            string output = ImportCategoryProducts(productShopContext, File.ReadAllText(@"../../../Datasets/categories-products.xml"));
            Console.WriteLine(output);*/

            string serialized = GetUsersWithProducts(productShopContext);
            File.WriteAllText(@"../../../Results/users-and-products.xml", serialized);
        }
        private static T Deserialize<T>(string inputXml, string rootName)
        {
            XmlRootAttribute root = new XmlRootAttribute(rootName);
            XmlSerializer serializer = new XmlSerializer(typeof(T), root);

            using StringReader reader = new StringReader(inputXml);

            T dtos = (T)serializer.Deserialize(reader);
            return dtos;
        }
        private static string Serializer<T>(T dataTransferObjects, string xmlRootAttributeName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(xmlRootAttributeName));

            StringBuilder sb = new StringBuilder();
            using var write = new StringWriter(sb);

            XmlSerializerNamespaces xmlNamespaces = new XmlSerializerNamespaces();
            xmlNamespaces.Add(string.Empty, string.Empty);

            serializer.Serialize(write, dataTransferObjects, xmlNamespaces);

            return sb.ToString();
        }

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            var usersDTO = Deserialize<List<ImportUserDTO>>(inputXml, "Users");

            var users = usersDTO.Select(uDTO => new User()
            {
                FirstName = uDTO.FirstName,
                LastName = uDTO.LastName,
                Age = uDTO.Age
            })
                .ToList();

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count}";
        }
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var productsDTOs = Deserialize<List<ImportProductDTO>>(inputXml, "Products");

            var products = productsDTOs
                .Select(pDTO => new Product()
                {
                    Name = pDTO.Name,
                    Price = pDTO.Price,
                    SellerId = pDTO.SellerId,
                    BuyerId = pDTO.BuyerId
                })
                .ToList();

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count}";
        }
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var categoryDTOs = Deserialize<List<ImportCategoriesDTO>>(inputXml, "Categories");

            var categories = categoryDTOs
                .Where(cDTO => cDTO.Name != null)
                .Select(cDTO => new Category()
                {
                    Name = cDTO.Name
                })
                .ToList();

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count}";
        }
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var cPDTO = Deserialize<List<ImportCategoriesProductsDTO>>(inputXml, "CategoryProducts");

            var categoryProducts = cPDTO
                .Where(dto => dto.ProductId != null && dto.CategoryId != null)
                .Select(dto => new CategoryProduct()
                {
                    ProductId = dto.ProductId,
                    CategoryId = dto.CategoryId
                })
                .ToList();

            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();

            return $"Successfully imported {categoryProducts.Count}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var productsInRange = context.Products
               .Where(p => p.Price >= 500 && p.Price <= 1_000)
               .OrderBy(p => p.Price)
               .Take(10)
               .Select(p => new ExportProductsInRangeDTO()
               {
                   Name = p.Name,
                   Price = p.Price,
                   BuyerFullName = p.Buyer.FirstName + " " + p.Buyer.LastName
               })
               .ToList();

            string xmlProducts = Serializer<List<ExportProductsInRangeDTO>>(productsInRange, "Products");
            return xmlProducts;
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
               .OrderByDescending(c => c.CategoryProducts.Count())
               .ThenBy(c => c.CategoryProducts.Select(cp => cp.Product.Price).Sum())
               .Select(c => new GetCategoriesByProductsCountDTO()
               {
                   Name = c.Name,
                   Count = c.CategoryProducts.Count(),
                   AveragePrice = c.CategoryProducts.Select(cp => cp.Product.Price).Average(),
                   TotalRevenue = c.CategoryProducts.Select(cp => cp.Product.Price).Sum()
               })
               .ToArray();

            var xmlCategories = Serializer<GetCategoriesByProductsCountDTO[]>(categories, "Categories");
            return xmlCategories;
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var usersInfo = context.Users
                .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null))
                .OrderByDescending(u => u.ProductsSold
                                          .Where(p => p.Buyer != null)
                                          .Count())
                .Select(u => new UserInfo()
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new SoldProductsDTO()
                    {
                        Count = u.ProductsSold
                                   .Where(ps => ps.Buyer != null).Count(),

                        Products = u.ProductsSold
                                    .Where(p => p.Buyer != null)
                                    .OrderByDescending(p => p.Price)
                                    .Select(p => new UsersSoldProductDTO()
                                    {
                                        Name = p.Name,
                                        Price = p.Price
                                    })
                                    .ToArray()
                    }
                })
                .Take(10)
                .ToArray();

            ExportUsersWProducts exportUsersWProducts = new ExportUsersWProducts()
            {
                Count = context.Users
                .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null)).Count(),
                UsersWProducts = usersInfo
            };

            return Serializer<ExportUsersWProducts>(exportUsersWProducts, "Users");
        }
    }
}