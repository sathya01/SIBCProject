using SIBCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIBCProject.Service;
using System.Globalization;

namespace SIBCProject.Controllers
{
    public class CalendarController : Controller
    {
        //
        // GET: /Calendar/

       private CalendarManager cal = new CalendarManager();
     
        public ActionResult Calendar()

        {
            
            var model = cal.getCalender(DateTime.Now.Month, DateTime.Now.Year);
            return View(model);
            //return View("Calendar");
        }

        public ActionResult AsyncUpdateCalender(int month, int year)
        {
            if (HttpContext.Request.IsAjaxRequest())
            {
                var model = cal.getCalender(month, year);
                return Json(model, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return View();
            }
        }


    }
}
