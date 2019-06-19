using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bluestate.Models;

namespace Bluestate.Controllers
{
    public class LoginController : Controller
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
            return View("../Pocetna/Pocetna");
        }
    }
}