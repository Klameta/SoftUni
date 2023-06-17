
namespace Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidation.Board;
    public class Board
    {
        public Board()
        {
            Tasks = new HashSet<Task>();
        }

        [Key] 
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}