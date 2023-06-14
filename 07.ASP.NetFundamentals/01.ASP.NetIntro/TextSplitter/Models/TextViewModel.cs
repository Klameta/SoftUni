using System.ComponentModel.DataAnnotations;

namespace TextSplitter.Models
{
    public class TextViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "The Text field is required")]
        [MinLength(2, ErrorMessage ="The Text must be longer than 2")]
        [MaxLength(30, ErrorMessage ="The Text must be shorter than 30")]
        public string Text { get; set; } = null!;
        public string SplitText { get; set; } = null!;
    }
}
