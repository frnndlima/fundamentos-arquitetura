using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}