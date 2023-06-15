using ForumApp.Data;
using ForumApp.Data.Models;
using ForumApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {
        private readonly ForumDbContext _data;

        public PostController(ForumDbContext data)
        {
            _data = data;
        }
        public IActionResult Index(ForumDbContext data)
        {
            return View();
        }

        public IActionResult All()
        {
            var posts = _data
                .Posts
                .Select(p => new PostViewModel()
                {
                    Id = p.Id.ToString(),
                    Title = p.Title,
                    Content = p.Content
                })
                .ToList();

            return View(posts);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PostFormModel model)
        {
            Post post = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

            _data.Posts.Add(post);
            _data.SaveChanges();

            return RedirectToAction(nameof(All));
        }

        public IActionResult Edit(string id)
        {
            var post = _data.Posts.FirstOrDefault(p => p.Id.ToString() == id);

            return View(new PostFormModel()
            {
                Title = post.Title,
                Content = post.Content
            });
        }

        [HttpPost]
        public IActionResult Edit(string id, PostFormModel model)
        {
            var post = _data.Posts.Find(Guid.Parse(id));

            post.Title = model.Title;
            post.Content = model.Content;

            _data.SaveChanges();

            return RedirectToAction(nameof(All));

        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            var post = _data.Posts.Find(Guid.Parse(id));

            _data.Posts.Remove(post);
            _data.SaveChanges();

            return RedirectToAction(nameof(All));
        }
    }
}
