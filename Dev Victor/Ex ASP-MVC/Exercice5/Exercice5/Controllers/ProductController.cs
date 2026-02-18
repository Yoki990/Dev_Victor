using Exercice5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5.Controllers
{
    [Route("Accueil")]
    public class ProductController : Controller
    {
        [HttpPost("Product")]
        public IActionResult TraitementProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View("Form", product);
            }
            ViewData["productName"] = product.Name;
            ViewData["productPrice"] = product.Price;
            ViewData["productCategory"] = product.Category;
            return RedirectToAction("Details");
        }

        [HttpGet("Product")]
        public IActionResult Form()
        {
            Product product = new Product();

            return View(product);
        }

        [Route("detail")]
        public IActionResult Details(Product product)
        {
            return View(product);
        }


    }
}
