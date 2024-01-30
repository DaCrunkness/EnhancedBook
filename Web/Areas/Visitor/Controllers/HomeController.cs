using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Visitor.Controllers
{
    [Area("Visitor")]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
