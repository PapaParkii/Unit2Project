using Microsoft.AspNetCore.Mvc;
using Unit2Project.Models;

namespace Unit2Project.Controllers
{
    public class HomeController : Controller
    {
        private VideogameContext context { get; set; }

        public HomeController(VideogameContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var videogames = context.Videogames.OrderBy(m => m.Name).ToList();
            return View(videogames);
        }
    }
}
