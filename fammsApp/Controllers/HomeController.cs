using Microsoft.AspNetCore.Mvc;

namespace fammsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

    }
}
