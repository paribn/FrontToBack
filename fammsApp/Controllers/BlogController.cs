using Microsoft.AspNetCore.Mvc;

namespace fammsApp.Controllers
{
    public class BlogController :Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
