using System.Diagnostics;
using Demo1_Controllers.Models;

//using Demo1_Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo1_Controllers.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Texte()
        {
            return Content("Voici du texte brut");
        }

        public IActionResult AfficherNom(string nom)
        {
            return Content("Bienvenue à " + nom);
        }

        public IActionResult AfficherId(int id)
        {
            return Content("Voici votre id : " + id);
        }

        public IActionResult AfficherPersonne()
        
        {
            Personne P = new Personne(1,"Toto","Tata",20);
            return Content(P.ToString());
        }

        public IActionResult AfficherPersonneJson()

        {
            Personne P = new Personne(1, "Toto", "Tata", 20);
            return Json(P);
        }

    }
}
