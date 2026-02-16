using Demo1_Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Controllers.Controllers
{
    public class PersonneController : Controller
    {
        private List<Personne> Personnes {  get; set; }

        public PersonneController()
        {
            Personnes = new List<Personne>();
            Personnes.Add(new Personne(1, "Toto", "Tata", 20));
            Personnes.Add(new Personne(2, "Titi", "Tutu", 30));
            Personnes.Add(new Personne(3, "Marco", "Polo", 40));
        }

        public IActionResult AfficherPersonne(int id)
        {
            return Json(Personnes.Where(p => p.Id == id).Single());
        }

        public IActionResult AfficherPersonneHtml(int id)
        {
            Personne p = Personnes.Where(p => p.Id == id).Single();

            ViewData["nom"]=p.Nom;
            ViewData["prenom"] = p.Prenom;
            ViewBag.Personne = p;
            return View();
        }

    }
}
