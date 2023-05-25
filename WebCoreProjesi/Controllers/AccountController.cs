using Microsoft.AspNetCore.Mvc;
using WebCoreProjesi.Models;

namespace WebCoreProjesi.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
            
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        public IActionResult Out()
        {
            return View();
        }
       
    }
}
