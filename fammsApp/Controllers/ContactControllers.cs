using Microsoft.AspNetCore.Mvc;

namespace fammsApp.Controllers
{
    public class ContactControllers:Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
