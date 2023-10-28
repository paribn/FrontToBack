using fammsApp.Data;
using fammsApp.Entities;
using fammsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace fammsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                Products = ProductData.ListProducts()
            };
            ProductData.ListProducts();

            return View(model);
        }

       

    }
}
