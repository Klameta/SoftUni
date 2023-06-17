
using System.ComponentModel.DataAnnotations;
using static Common.EntityValidation.Task;
namespace TaskBoardApp.Models.Task
{
    public class TaskFormModel
    {
        [Required]
        [StringLength(TitleMaxLenght, ErrorMessage = "The {0} should be at least {2} charachters long or {1} charachters at most", MinimumLength = TitleMinLenght)]
        public string Title { get; set; }
        [Required]
        [StringLength(DescriptionMaxLenght, ErrorMessage = "The {0} should be at least {2} charachters long or {1} charachters at most", MinimumLength = DescriptionMinLenght)]
        public string Description { get; set; }
        [Display(Name = "Board")]
        public int BoardId { get; set; }

        public IEnumerable<TaskBoardModel> Boards { get; set; }
    }
}
