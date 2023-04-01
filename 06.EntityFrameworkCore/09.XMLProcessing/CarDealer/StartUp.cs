using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using System.Xml;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            CarDealerContext context = new CarDealerContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            ImportSuppliers(context, File.ReadAllText(@"../../../Datasets/suppliers.xml"));
            ImportParts(context, File.ReadAllText(@"../../../Datasets/parts.xml"));
            string output = ImportParts(context, File.ReadAllText(@"../../../Datasets/parts.xml"));
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
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            var suppliersDTO = Deserialize<ImportSuppliersDTO[]>(inputXml, "Suppliers");

            var suppliers = suppliersDTO.Select(dto => new Supplier
            {
                Name = dto.Name,
                IsImporter = dto.IsImported
            })
                .ToList();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}";
        }
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            var parts = Deserialize<List<ImportPartDTO>>(inputXml, "Parts")
                .Where(p => context.Suppliers.FirstOrDefault(s => s.Id == p.SupplierId) != null)
                .Select(dto => new Part
                {
                    Name = dto.Name,
                    Price = dto.Price,
                    Quantity = dto.Quantity,
                    SupplierId = dto.SupplierId
                })
                .ToList();

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";
        }
    }
}