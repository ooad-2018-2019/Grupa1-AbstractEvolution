using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bluestate.Models;

namespace Bluestate.Controllers
{
    public class HomeController : Controller
    {
        private static DatabaseContext database = DatabaseContext.getInstance();
        public static Korisnik currentyLoggedPerson = null;
        public static Admin currentyLoggedAdministrator = null;
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        [HttpPost]
        public IActionResult SignIn(string etUsername, string etPassword) {
            var dataAdmin = database.Administrator.Where((Admin administrator) => administrator.Username.Equals(etUsername) && administrator.Password.Equals(etPassword));
            var data = database.Korisnik.Where((Korisnik person) => person.Username.Equals(etUsername) && person.Password.Equals(etPassword));
            if (!data.Any() && !dataAdmin.Any())
                return View("Index");
            else if (!dataAdmin.Any()) {
                // User || Employee
                currentyLoggedPerson = data.First();
            }
           /* currentyLoggedAdministrator = dataAdmin.First();*/
            return View("Index");
        }
    }
}