using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using TaskBoardApp.Data;
using TaskBoardApp.Models;
using TaskBoardApp.Models.Home;

namespace TaskBoardApp.Controllers
{
    public class HomeController : Controller
    {
        private static TaskBoardAppDbContext _data;
        public HomeController(TaskBoardAppDbContext context)
        {
            _data = context;
        }
        public async Task<IActionResult> Index()
        {
            var taskBoards = _data
                .Boards
                .Select(b => b.Name)
                .Distinct();

            var tasksCount = new List<HomeBoardModel>();
            foreach (var boardName in taskBoards)
            {
                var tasksInBoard = _data
                    .Tasks
                    .Where(b => b.Board.Name == boardName)
                    .Count();
                tasksCount.Add(new HomeBoardModel()
                {
                    BoardName = boardName,
                    TasksCount = tasksInBoard
                });
            }
            var usersTasksCount = -1;

            if (User.Identity.IsAuthenticated)
            {
                var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                usersTasksCount = _data.Tasks.Where(t => t.OwnerId == currentUserId).Count();
            }

            var homeModel = new HomeViewModel()
            {
                BoardsWithTasksCount = tasksCount,
                UserTasksCount = usersTasksCount,
                AllTasksCount = _data.Tasks.Count()
            };


            return View(homeModel);
        }
    }
}