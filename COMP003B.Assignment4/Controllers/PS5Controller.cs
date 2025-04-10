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
        public  IActionResult Games()
        {
            return View();
        }

        [HttpGet("accessories")]
        public IActionResult Accessroies()
        {
            return View();
        }
    }
}
