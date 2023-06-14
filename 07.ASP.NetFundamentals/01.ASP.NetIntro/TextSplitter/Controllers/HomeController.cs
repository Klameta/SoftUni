using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TextSplitter.Models;

namespace TextSplitter.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(TextViewModel model)
        {
            return View(model);
        }

        [HttpPost]
        public IActionResult Split(TextViewModel model)
        {
            var splittedText = model.Text
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            model.SplitText = string.Join(Environment.NewLine, splittedText);

            return RedirectToAction(nameof(Index), model);
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}