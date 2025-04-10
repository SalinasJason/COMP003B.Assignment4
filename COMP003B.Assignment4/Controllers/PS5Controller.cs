using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    [Route("PS5")]
    public class PS5Controller : Controller
    {
        [HttpGet("home")]
        public IActionResult Home()
        {
            return View();
        }

        [HttpGet("games")]
        public IActionResult Games()
        {
            var games = new List<Game>
            {
                new Game { Name = "God of War Ragnarok", Genre = "Action-adventure", Price = 59.99 },
                new Game { Name = "Spider-Man", Genre = "Action", Price = 49.99 },
                new Game { Name = "Elden Ring", Genre = "RPG", Price = 59.99 },
                new Game { Name = "The Last of Us Part 1 ", Genre = "Action-adventure", Price = 59.99 },
                new Game { Name = "Horizon Forbidden West", Genre = "Action-RPG", Price = 59.99 },
                new Game { Name = "Ratchet & Clank Rift Apart", Genre = "Action-adventure", Price = 59.99 },
            };
            return View(games);
        }

        [HttpGet("accessories")]
        public IActionResult Accessories()
        {
            return View();
        }
    }
}
