using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using static ForumApp.Common.EntityValidations.Post;

namespace ForumApp.Data
{
    public class PostFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; }
        [Required]
        [StringLength(ContentMaxLenght, MinimumLength = ContentMinLenght)]
        public string Content { get; set; }
    }
}
