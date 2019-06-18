using Bluestate.Models;

namespace Bluestate.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;


    namespace Bluestate.Controllers
    {
        public class UserController : Controller
        {
            private DatabaseContext database = DatabaseContext.getInstance();
          

          /*  public IActionResult Index()
            {
                return View("", LoginController.currentyLoggedPerson); //za logiranog otvarati viewove ovdje i nastaviti rad
            }

            public IActionResult TabSportsCentres()
            {
                return View("", LoginController.currentyLoggedPerson);
            }*/


            public IActionResult UserSignOut_OnClick()
            {
                LoginController.currentyLoggedPerson = null;
                database.SaveChanges();
                return View("../Login/Index");
            }

        }
    }
}