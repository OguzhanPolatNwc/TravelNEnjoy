using Microsoft.AspNetCore.Mvc;

namespace Travel_N_Enjoy.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult Password()
        {
            return View();
        }
    }
}

