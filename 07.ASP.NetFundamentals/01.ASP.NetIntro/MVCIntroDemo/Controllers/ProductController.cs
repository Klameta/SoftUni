using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using MVCIntroDemo.Models;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace MVCIntroDemo.Controllers
{
    public class ProductController : Controller
    {
        private IEnumerable<ProductViewModel> _products = new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id = 1,
                Name = "Cheese",
                Price = 7.00
            },

            new ProductViewModel()
            {
                Id = 2,
                Name = "Ham",
                Price = 5.00
            },

            new ProductViewModel()
            {
                Id = 3,
                Name = "Bread",
                Price =1.50
            }
        };


        [ActionName("My-Products")]
        public IActionResult All()
        {
            return View(_products);
        }

        public IActionResult ById(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return BadRequest();
            }
            return View(product);
        }

        public IActionResult AllAsJson()
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            return Json(_products, options);
        }

        public IActionResult AllAsText()
        {
            string result = string.Join(Environment.NewLine, _products
                .Select(p => $"Product {p.Id}: {p.Name} - {p.Price} lv."));

            return Content(result);
        }

        public IActionResult AllAsTextFile()
        {
            string result = string.Join(Environment.NewLine, _products
                .Select(p => $"Product {p.Id}: {p.Name} - {p.Price} lv."));

            Response.Headers.Add(HeaderNames.ContentDisposition, @"attachment;filename=product.txt");

            return File(Encoding.UTF8.GetBytes(result), "text/plain");
        }
    }
}
