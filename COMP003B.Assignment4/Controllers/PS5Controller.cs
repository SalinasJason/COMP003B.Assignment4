using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class PS5Controller : Controller
    {
        [HttpGet]
        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public  IActionResult Games()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Accessries()
        {
            return View();
        }
    }
}
