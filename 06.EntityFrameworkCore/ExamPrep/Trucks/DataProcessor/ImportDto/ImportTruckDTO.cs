using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Trucks.DataProcessor.ImportDto
{
    [XmlType("Truck")]
    public class ImportTruckDTO
    {
        [RegularExpression(@"[A-Z]{2}\d{4}[A-Z]{2}")]
        public string? RegistrationNumber { get; set; }
        [MinLength(17)]
        [MaxLength(17)]
        public string VinNumber { get; set; }
        [Range(950, 1_420)]
        public int TankCapacity { get; set; }
        [Range(5_000, 29_000)]
        public int CargoCapacity { get; set; }
        [Range(0, 3)]
        public int CategoryType { get; set; }
        [Range(0, 4)]
        public int MakeType { get; set; }
    }
}
