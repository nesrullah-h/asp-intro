using Microsoft.AspNetCore.Mvc;

namespace ASP_Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
