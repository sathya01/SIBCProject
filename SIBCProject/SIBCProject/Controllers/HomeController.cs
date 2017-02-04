using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIBCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {         

            return View("");
        }

       

        public ActionResult GetInvolved()
        {
            return View("GetInvolved");
        }
        public ActionResult Visit()
        {
            return View("Visit");
        }
     
      
        public ActionResult Resources()
        {
            return View("Resources");
        }
        public ActionResult Gallery()
        {
            return View("Gallery");
        }
        public ActionResult FoodItems()
        {
            return View("FoodItems");
        }

    }
}
