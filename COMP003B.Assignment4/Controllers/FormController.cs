using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;


namespace COMP003B.Assignment4.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterForm(FormRegistration registration)
        {
            if (!ModelState.IsValid)
            {
                return View(registration);
            }
            return RedirectToAction("Success", registration);
        }

        [HttpGet]
        public IActionResult Success(FormRegistration registration)
        {
            return View(registration);
        }
    }
}
