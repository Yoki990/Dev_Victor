using Exercice4.Interfaces;
using Exercice4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4.Controllers
{
    public class ProductController : Controller
    {
        IProductService ProductService { get; set; }
        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }
        
        public IActionResult AfficherAllProducts()
        {
            Product p = ProductService.RecupererTousLesProduits();
            return View(p);
        }

        public IActionResult RecupererProduitParId()
        {
            return View();
        }

        public IActionResult FilterParCategorieEtPrix()
        {
            return View();
        }
    }
}
