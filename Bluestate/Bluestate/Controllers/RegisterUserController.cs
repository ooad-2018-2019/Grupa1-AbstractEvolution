using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bluestate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;

namespace Bluestate.Controllers {
    public class RegisterUserController : Controller {
        private static DatabaseContext database = DatabaseContext.getInstance();

        public IActionResult Index() {
            return View("RegistrationForm");
        }

        [HttpPost]
        public IActionResult Validate(string etFirstName, string etLastName, string etEmail, string etUsername, string etPassword, string etConfirmPassword) {
            return View("../Pocetna/Pocetna");
        }
    }
}