using ProductShop.Data;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            ProductShopContext productShopContext = new ProductShopContext();
            productShopContext.Database.EnsureDeleted();
            productShopContext.Database.EnsureCreated();

            ImportUsers(productShopContext, File.ReadAllText(@"../../../Datasets/users.xml"));
            ImportProducts(productShopContext, File.ReadAllText(@"../../../Datasets/products.xml"));
            ImportCategories(productShopContext, File.ReadAllText(@"../../../Datasets/categories.xml"));

            string output = ImportCategoryProducts(productShopContext, File.ReadAllText(@"../../../Datasets/categories-products.xml"));
            Console.WriteLine(output);
        }
        private static T Deserialize<T>(string inputXml, string rootName)
        {
            XmlRootAttribute root = new XmlRootAttribute(rootName);
            XmlSerializer serializer = new XmlSerializer(typeof(T), root);

            using StringReader reader = new StringReader(inputXml);

            T dtos = (T)serializer.Deserialize(reader);
            return dtos;
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
    }
}