using Microsoft.AspNetCore.Mvc;

namespace Exercice1.Controllers
{
    public class RandomController : Controller
    {
        public IActionResult Index()
        {
            Random random = new Random();
            int nbAleatoire = random.Next(1,100);
            ViewData["nbAleatoire"] = nbAleatoire;
            return View();

        }
    }
}
