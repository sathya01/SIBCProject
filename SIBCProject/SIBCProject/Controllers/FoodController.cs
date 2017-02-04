using SIBCProject.Models;
using SIBCProject.Service;
using System.Web.Mvc;
using System.Collections.Generic;

namespace SIBCProject.Controllers
{
    public class FoodController : Controller
    {
        
        
        public ActionResult FoodItems()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult FoodItems(Food food)
        {
            SaveFoodList.SaveData(food);

            return Content("Record Added");
        }

    }
}
