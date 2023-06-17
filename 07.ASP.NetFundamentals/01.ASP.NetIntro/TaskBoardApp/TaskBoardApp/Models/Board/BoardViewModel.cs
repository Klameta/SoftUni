using DataModels;
using TaskBoardApp.Models.Task;

namespace TaskBoardApp.Models.Board
{
    public class BoardViewModel
    {
        public string Name { get; set; }
        public ICollection<TaskViewModel> Tasks { get; set; }
    }
}
