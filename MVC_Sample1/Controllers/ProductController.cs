using MVC_Sample1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sample1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var lstProducts = new List<Product>();
            var banana = new Product { Id = 1, Description = "Good", Name = "Banana", Price = 32.4m, Quantity = 10 };
            var lemon = new Product { Id = 2, Description = "Yellow", Name = "Lemon", Price = 67.4m, Quantity = 50 };
            var guava = new Product { Id = 3, Description = "Sweet", Name = "Guava", Price = 43.5m, Quantity = 20 };
            var kiwi = new Product { Id = 4, Description = "Nice", Name = "Kiwi", Price = 87.4m, Quantity = 40 };
            lstProducts.Add(banana);
            lstProducts.Add(lemon);
            lstProducts.Add(guava);
            lstProducts.Add(kiwi);

            return View(lstProducts);
        }
    }
}