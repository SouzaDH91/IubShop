using IubShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IubShop.Controllers
{
    public class ProductController : Controller
    {
        /*
         * ActionResult
         * IActionResult
         */
        public ActionResult Show()
        {
            Product product = GetProduct();

            return View(product);
            //return new ContentResult() { Content = "<h3>product -> view</h3>", ContentType = "text/html" };
        }

        private Product GetProduct()
        {
            return new Product()
            {
                id = 1,
                name = "Xbox One X",
                price = 1565.50,
                description = "Jogue em 4K com o melhor console da atualidade!"
            };
        }
    }
}
