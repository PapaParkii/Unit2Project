using Microsoft.AspNetCore.Mvc;
using Unit2Project.Models;

namespace Unit2Project.Controllers {
    public class VideogameController : Controller {
        private VideogameContext context { get; set; }
        public VideogameController(VideogameContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Videogame());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var videogame = context.Videogames.Find(id);
            return View(videogame);
        }
        [HttpPost]
        public IActionResult Edit(Videogame videogame)
        {
            if (ModelState.IsValid)
            {
                if (videogame.VideogameID == 0)
                    context.Videogames.Add(videogame);
                else
                    context.Videogames.Update(videogame);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (videogame.VideogameID == 0) ? "Add" : "Edit";
                return View(videogame);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var videogame = context.Videogames.Find(id);
            return View(videogame);
        }
        [HttpPost]
        public IActionResult Delete(Videogame videogame)
        {
            context.Videogames.Remove(videogame);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
