using Microsoft.AspNetCore.Mvc;

namespace GamesAppProiect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
