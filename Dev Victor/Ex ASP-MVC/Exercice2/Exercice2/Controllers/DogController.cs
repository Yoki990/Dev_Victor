using Exercice2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2.Controllers
{
    public class DogController : Controller
    {
        private List<Dog> Chiens {  get; set; }

        public DogController()
        {
            Chiens = new List<Dog>();
            Chiens.Add(new Dog(1,"Beethoven", 20, "Breed1"));
            Chiens.Add(new Dog(2,"Snoopy", 5, "Breed2"));
            Chiens.Add(new Dog(3,"Idéfix", 40, "Breed3"));
        }

        public IActionResult Display(int id)
        {           
            if (id < 1 || id > 3)
            {
                return RedirectToAction("DisplayAll");
            }
            else
            {
                Dog d = Chiens.Where(d => d.Id == id).Single();
                ViewData["nom"] = d.Name;
                ViewData["age"] = d.Age;
                ViewData["breed"] = d.Breed;

                return View();
            }
            
        }

        public IActionResult DisplayAll()
        {
            foreach (var d in Chiens)
            {
                ViewData["nom"] = d.Name;
                ViewData["age"] = d.Age;
                ViewData["breed"] = d.Breed;
            }
            return View();

        }

        public IActionResult Greeting(string name)
        {
            if (name == null)
            {
                return Content("Bienvenue sur la page");
            }
            else
            {
                ViewData["prénom"] = name;
                return View();
            }
            
            
        }
    }
}
