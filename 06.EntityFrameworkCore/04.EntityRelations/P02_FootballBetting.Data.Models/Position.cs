﻿using System.ComponentModel.DataAnnotations;

namespace P02_FootballBetting.Data.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}