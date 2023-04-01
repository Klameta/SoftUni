using Boardgames.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.DataProcessor.ImportDto
{
    public class ImportSellerDTO
    {
        [JsonProperty("Name")]
        [MinLength(5)]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
        [JsonProperty("Address")]
        [MinLength(2)]
        [MaxLength(30)]
        [Required]
        public string Address { get; set; }
        [JsonProperty("Country")]
        [Required]
        public string Country { get; set; }
        [JsonProperty("Website")]
        [RegularExpression(@"(www.)[\w,-]+(.com){1}$")]
        [Required]
        public string Website { get; set; }
        [JsonProperty("Boardgames")]
        public int[] BoardgamesIds { get; set; }
        
    }
}
