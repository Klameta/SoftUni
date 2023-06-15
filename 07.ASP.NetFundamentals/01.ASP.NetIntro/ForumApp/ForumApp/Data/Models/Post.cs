using System.ComponentModel.DataAnnotations;
using static ForumApp.Common.EntityValidations.Post;
namespace ForumApp.Data.Models
{
    public class Post
    {
        public Post()
        {
            this.Id = new Guid();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(TitleMaxLength)]
        [MinLength(TitleMinLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(ContentMaxLenght)]
        [MinLength(ContentMinLenght)]
        public string Content { get; set; }
    }
}
