using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
    [XmlType("Boardgame")]
    public class ImportBoardgamesDTO
    {
        [XmlElement("Name")]
        [MinLength(10)]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
        [XmlElement("Rating")]
        [Range(1, 10.00)]
        [Required]
        public double Rating { get; set; }
        [XmlElement("YearPublished")]
        [Range(2018, 2023)]
        [Required]
        public int YearPublished { get; set; }
        [XmlElement("CategoryType")]
        [Range(0, 4)]
        [Required]
        public int CategoryType { get; set; }
        [Required]
        public string Mechanics { get; set; }
    }
}