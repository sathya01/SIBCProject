using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIBCProject.Models;

namespace SIBCProject.Controllers
{
    public class UserRegistrationController : Controller
    {
        
        // GET: /UserRegistration/
        //static List<UserRegistration> user = new List<UserRegistration>();
        
        public ActionResult WorkwithUs()
        {
           UserRegistration user = new UserRegistration();
            return View(user);
        }

        [HttpPost]
        public ActionResult WorkwithUs(UserRegistration us)
        {
        
             Savexml.SaveData(us);
             return Content("Record Added");
        }
    }
}
