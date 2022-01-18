using Microsoft.AspNetCore.Mvc;

namespace Travel_N_Enjoy.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Settings()
        {
            return View();
        }
        
        public IActionResult Contact()
        {
            return View();
        }
    }
}

