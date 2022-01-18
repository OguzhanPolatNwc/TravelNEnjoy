using Microsoft.AspNetCore.Mvc;

namespace Travel_N_Enjoy.Controllers
{
    public class EnjoyController : Controller
    {
        public IActionResult Amusement()
        {
            return View();
        }
        
        public IActionResult Courses()
        {
            return View();
        }
    }
}

