using Bluestate.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bluestate.Controllers
{
    public class NekretninaController : Controller
    {
        private static DatabaseContext database = DatabaseContext.getInstance();

        public IActionResult Index() {
            return View("Nekretnina");
        }
        
        
        public IActionResult VratiNazad() {
            return View("../Login/Index");
        }
    }
}