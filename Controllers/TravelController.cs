using Microsoft.AspNetCore.Mvc;

namespace Travel_N_Enjoy.Controllers
{
    public class TravelController : Controller
    {
        public IActionResult Accomodation()
        {
            return View();
        }
        
        public IActionResult Transportation()
        {
            return View();
        }
    }
}

