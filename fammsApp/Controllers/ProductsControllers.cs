using Microsoft.AspNetCore.Mvc;

namespace fammsApp.Controllers
{
    public class ProductsControllers:Controller
    {

        public IActionResult Index()
        {

            return View();
        }
    }
}
