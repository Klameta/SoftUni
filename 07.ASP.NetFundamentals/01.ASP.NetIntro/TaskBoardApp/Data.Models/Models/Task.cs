using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Common.EntityValidation.Task;

namespace Data.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(TitleMaxLenght)]
        public string Title { get; set; } = null!;
        [Required]
        [MaxLength(DescriptionMaxLenght)]
        public string Description { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        [ForeignKey(nameof(Board))]
        public int BoardId { get; set; }
        public Board Board { get; set; }
        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; } = null!;
        public IdentityUser Owner { get; set; } = null!;
    }
}