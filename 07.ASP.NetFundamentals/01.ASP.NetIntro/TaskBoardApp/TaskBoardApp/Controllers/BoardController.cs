using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data;
using TaskBoardApp.Models;
using TaskBoardApp.Models.Board;
using TaskBoardApp.Models.Task;

namespace TaskBoardApp.Controllers
{
    public class BoardController : Controller
    {
        private readonly TaskBoardAppDbContext _context;

        public BoardController(TaskBoardAppDbContext context)
        {
            _context = context;
        }

        public IActionResult All()
        {

            var boards = _context
                .Boards
                .Select(b => new BoardViewModel()
                {
                    Name = b.Name,
                    Tasks = b
                    .Tasks
                    .Select(t => new TaskViewModel()
                    {
                        Id = t.Id,
                        Title = t.Title,
                        Description = t.Description,
                        Owner = t.Owner.UserName
                    })
                    .ToArray()
                })
                    .ToArray();

            return View(boards);
        }

    }
}
