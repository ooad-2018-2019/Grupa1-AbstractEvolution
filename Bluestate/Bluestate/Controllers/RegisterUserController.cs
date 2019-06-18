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
            Boolean validationOk = true;
            if (etFirstName.Equals("") || etLastName.Equals("") || etUsername.Equals("") || etPassword.Equals("") || etConfirmPassword.Equals("") || etEmail.Equals("")) validationOk = false;
            if (!etPassword.Equals(etConfirmPassword)) validationOk = false;

            var people = database.Korisnik.Where((Korisnik person) => person.Username.Equals(etUsername));
            var admins = database.Administrator.Where((Admin administrator) => administrator.Username.Equals(etUsername));
            if (people.Count() != 0 || admins.Count() != 0) validationOk = false;

            if (validationOk) {
                database.Korisnik.Add(new Kupac {
                    ImePrezime = etFirstName+" "+etLastName,
                    Username = etUsername,
                    Password = etPassword,
                    Email = etEmail,
            
                });
                database.SaveChanges();
                var peopleUpdated = database.Korisnik.Where((Korisnik person) => person.Username.Equals(etUsername)).ToList();
                Korisnik thisPerson = peopleUpdated[0];

                database.SaveChanges();
                return View("../Login/Index");
            }
            return View("RegistrationForm");
        }
    }
}