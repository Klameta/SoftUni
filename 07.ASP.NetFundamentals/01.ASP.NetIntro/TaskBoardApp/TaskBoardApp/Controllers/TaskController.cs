using DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using NuGet.Protocol;
using System.Security.Claims;
using TaskBoardApp.Data;
using TaskBoardApp.Models.Task;

namespace TaskBoardApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskBoardAppDbContext _data;
        public TaskController(TaskBoardAppDbContext data)
        {
            _data = data;
        }

        public async Task<IActionResult> Create()
        {
            TaskFormModel taskFormModel = new TaskFormModel()
            {
                Boards = GetBoards()
            };
            return View(taskFormModel);
        }
        [HttpPost]
        public IActionResult Create(TaskFormModel taskModel)
        {
            if (!GetBoards().Any(b => b.Id == taskModel.BoardId))
            {
                this.ModelState.AddModelError(nameof(taskModel.BoardId), "Board does not exist.");
            }

            string currentUserId = GetUserId();
            DataModels.Task task = new()
            {
                Title = taskModel.Title,
                Description = taskModel.Description,
                BoardId = taskModel.BoardId,
                OwnerId = currentUserId,
                CreatedOn = DateTime.Now
            };

            this._data.Tasks.Add(task);
            this._data.SaveChanges();

            var boards = this._data.Boards;
            return RedirectToAction("All", "Board");
        }

        public async Task<IActionResult> Details(int id)
        {
            var task = await _data
                .Tasks
                .Where(t => t.Id == id)
                .Select(t => new TaskDetailsViewModel()
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    CreatedOn = t.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
                    Board = t.Board.Name,
                    Owner = t.Owner.UserName
                })
                .FirstOrDefaultAsync();

            if (task == null)
            {
                return BadRequest();
            }

            return View(task);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var task = await _data.Tasks.FindAsync(id);

            if (task == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();

            if (currentUserId != task.OwnerId)
            {
                return Unauthorized();
            }

            TaskFormModel taskFormModel = new TaskFormModel()
            {
                Title = task.Title,
                Description = task.Description,
                BoardId = task.BoardId,
                Boards = GetBoards()
            };

            return View(taskFormModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TaskFormModel formModel)
        {
            DataModels.Task? task = await _data.Tasks.FindAsync(id);

            if (task == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();
            if (currentUserId != task.OwnerId)
            {
                Unauthorized();
            }

            if (!GetBoards().Any(b => b.Id == task.BoardId))
            {
                this.ModelState.AddModelError(nameof(task.BoardId), "Board does not exist!");
            }

            task.Title = formModel.Title;
            task.BoardId = formModel.BoardId;
            task.Description = formModel.Description;

            await this._data.SaveChangesAsync();

            return RedirectToAction("All", "Board");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            DataModels.Task? task = await _data.Tasks.FindAsync(id);

            if (task==null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();
            if (currentUserId!=task.OwnerId)
            {
                return Unauthorized();
            }

            TaskViewModel taskModel = new TaskViewModel()
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description
            };

            return View(taskModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(TaskViewModel taskModel)
        {
            var task = await _data.Tasks.FindAsync(taskModel.Id);
            if(task==null)
            {
                return BadRequest();
            }

            var currUserId = GetUserId();
            if (currUserId!=task.OwnerId)
            {
                return Unauthorized();
            }

            _data.Tasks.Remove(task);
            await _data.SaveChangesAsync();

            return RedirectToAction("All", "Board");
        }


        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        private IEnumerable<TaskBoardModel> GetBoards()
        {
            var boards = _data
                .Boards
                .Select(b => new TaskBoardModel()
                {
                    Id = b.Id,
                    Name = b.Name
                });
            return boards;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

