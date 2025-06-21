using CourseraMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseraMVCProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                if (model.UserName == "admin" && model.Password == "admin123.")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is invalid");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
    }
}
