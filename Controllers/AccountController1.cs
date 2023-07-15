using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class AccountController1 : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            if (Username != null && Password != null)
            {
                // TO DO:
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
