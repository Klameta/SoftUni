﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicHub.Data.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [NotMapped]
        public decimal Price => Songs.Sum(s => s.Price);
        [ForeignKey(nameof(Producer))]
        public int? ProducerId { get; set; }
        public Producer? Producer { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}