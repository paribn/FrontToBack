using Microsoft.AspNetCore.Mvc;

namespace fammsApp.Controllers
{
    public class AboutController :Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
