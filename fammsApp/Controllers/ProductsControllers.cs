using fammsApp.Data;
using fammsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace fammsApp.Controllers
{
    public class ProductsControllers:Controller
    {
        public IActionResult Index()
        {

            var model = new ProductIndexViewModel
            {
                Products = ProductData.ListProducts()
            };
            ProductData.ListProducts();

            return View(model);
        }

    }
}
