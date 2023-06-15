using System.ComponentModel.DataAnnotations;
using static ForumApp.Common.EntityValidations.Post;
namespace ForumApp.Models
{
    public class PostViewModel
    {
        public string Id { get; set; }
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(ContentMaxLenght, MinimumLength = ContentMinLenght)]
        public string Content { get; set; } = null!;
    }
}
