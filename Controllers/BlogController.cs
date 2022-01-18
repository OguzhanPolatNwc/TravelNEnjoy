using Microsoft.AspNetCore.Mvc;

namespace Travel_N_Enjoy.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

