using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3.Controllers
{
    public class DisplayController: Controller
    {
        public IActionResult Index()
        {
            ViewData["string"] = "Toto";
            ViewData["int"] = 15;
            int age = (int)ViewData["int"];
            List<string> Hobbies = new List<string>() { "Peinture", "Escrime", "Jeux Vidéos", "Dessin", "Couture"};
            ViewData["hobbies"] = Hobbies;

            bool estMajeur = age >= 18;
            ViewBag.estMajeur = estMajeur;
            ViewBag.age = ViewData["int"];
            return View();
        }
    }
}
