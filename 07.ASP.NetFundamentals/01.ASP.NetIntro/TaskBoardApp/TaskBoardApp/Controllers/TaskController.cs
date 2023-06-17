using Microsoft.AspNetCore.Mvc;
using TaskBoardApp.Data;

namespace TaskBoardApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskBoardAppDbContext _data;
        public TaskController(TaskBoardAppDbContext data)
        {
            _data = data;
        }

        [HttpPost]
        public IActionResult Create()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
