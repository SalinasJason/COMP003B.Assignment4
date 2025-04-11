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
                new Game { Name = "God of War Ragnarok", ImageUrl = "/Images/Game-God.jfif", Genre = "Action-adventure", Price = 59.99 },
                new Game { Name = "Marvel Spider-Man 2", ImageUrl = "/Images/Game-Spider.jfif", Genre = "Action", Price = 59.99 },
                new Game { Name = "Elden Ring", ImageUrl = "/Images/Game-Elden.jfif", Genre = "RPG", Price = 59.99 },
                new Game { Name = "The Last of Us Part 1 ", ImageUrl = "/Images/Game-Last.jfif", Genre = "Action-adventure", Price = 59.99 },
                new Game { Name = "Horizon Forbidden West", ImageUrl = "/Images/Game-Horizon.jfif", Genre = "Action-RPG", Price = 59.99 },
                new Game { Name = "Ratchet & Clank Rift Apart", ImageUrl = "/Images/Game-Ratchet.jfif", Genre = "Action-adventure", Price = 59.99 },
            };
            return View(games);
        }

        [HttpGet("accessories")]
        public IActionResult Accessories()
        {
            var acessories = new List<Accessories>
            {
                new Accessories { Name = "DualSense Wireless Controller", ImageUrl = "/Images/PS5-Controller.webp", Price = 69.99 },
                new Accessories { Name = "PULSE Elite wireless headset", ImageUrl = "/Images/PS5-Headset.webp", Price = 69.99 },
                new Accessories { Name = "Internal M.2 SSD 2TB", ImageUrl = "/Images/PS5-ssd.webp", Price = 184.99 },
            };
            return View(acessories);
        }
    }
}

