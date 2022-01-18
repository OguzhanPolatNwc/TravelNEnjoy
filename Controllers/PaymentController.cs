using Microsoft.AspNetCore.Mvc;

namespace Travel_N_Enjoy.Controllers
{
    public class Payment : Controller
    {
        public IActionResult Bill()
        {
            return View();
        }
        
        public IActionResult MyOrder()
        {
            return View();
        }
        
        public IActionResult myCard()
        {
            return View();
        }
    }
}

