namespace Trucks.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Xml.Serialization;
    using Data;
    using Trucks.Data.Models;
    using Trucks.Data.Models.Enums;
    using Trucks.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedDespatcher
            = "Successfully imported despatcher - {0} with {1} trucks.";

        private const string SuccessfullyImportedClient
            = "Successfully imported client - {0} with {1} trucks.";

        private static T Deserialize<T>(string inputXml, string rootName)
        {
            XmlRootAttribute root = new XmlRootAttribute(rootName);
            XmlSerializer serializer = new XmlSerializer(typeof(T), root);

            using StringReader reader = new StringReader(inputXml);

            T dtos = (T)serializer.Deserialize(reader);
            return dtos;
        }

        public static string ImportDespatcher(TrucksContext context, string xmlString)
        {
            var despatcherDTOs = Deserialize<ImportDespatcherDBO[]>(xmlString, "Despatchers");
            var validDespatchers = new HashSet<Despatcher>();
            StringBuilder sb = new StringBuilder();


            foreach (var despatcherDTO in despatcherDTOs)
            {

                if (!IsValid(despatcherDTO))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var validTrucks = new HashSet<Truck>();
                foreach (var truckDTO in despatcherDTO.Trucks)
                {
                    if (!IsValid(truckDTO))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    /*if (!Regex.IsMatch(truckDTO.RegistrationNumber, @"[A-Z]{2}\d{4}[A-Z]{2}"))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }*/

                    Truck truck = new Truck()
                    {
                        RegistrationNumber = truckDTO.RegistrationNumber,
                        VinNumber = truckDTO.VinNumber,
                        TankCapacity = truckDTO.TankCapacity,
                        CargoCapacity = truckDTO.CargoCapacity,
                        CategoryType = (CategoryType)truckDTO.CategoryType,
                        MakeType = (MakeType)truckDTO.MakeType
                    };


                    validTrucks.Add(truck);
                }
                Despatcher despatcher = new Despatcher()
                {
                    Name = despatcherDTO.Name,
                    Position = despatcherDTO.Position,
                    Trucks = validTrucks
                };
                validDespatchers.Add(despatcher);

                sb.AppendLine($"Successfully imported despatcher - {despatcherDTO.Name} with {validTrucks.Count} trucks.");
            }
            context.Despatchers.AddRange(validDespatchers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportClient(TrucksContext context, string jsonString)
        {
            throw new NotImplementedException();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}