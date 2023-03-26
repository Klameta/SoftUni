using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
    public class Team
    {
        
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        [StringLength(3)]
        public string Initials { get; set; }
        public decimal Budget { get; set; }
        [ForeignKey("PrimaryKitColor")]
        public int PrimaryKitColorId { get; set; }
        public virtual Color PrimaryKitColor { get; set; }
        [ForeignKey("SecondaryKitColor")]
        
        public int SecondaryKitColorId { get; set; }
        public virtual Color SecondaryKitColor { get; set; }
        [ForeignKey("Town")]
        public int TownId { get; set; }
        public virtual Town Town { get; set; }

        [InverseProperty(nameof(Game.HomeTeam))]
        public virtual ICollection<Game> HomeGames { get; set; }
        [InverseProperty(nameof(Game.AwayTeam))]
        public virtual ICollection<Game> AwayGames { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
