using Fuel.BuisnessLogic;
using Fuel.ViewModel;
using Fuel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fuel.Controllers
{
    public class FuelController : Controller
    {

        /// konstruktor
        private readonly FuelBuisnessLogic _buisnessLogic;

        public FuelController()
        {
            _buisnessLogic = new FuelBuisnessLogic();
        }

        // GET: Fuel podbarnie z serwera
        public ActionResult Index()
        {
            var model = new FuelviewModel { Fuelmodel = new FuelModel() };
            return View("FuelCalculate", model);
        }
        [HttpPost]
        public ActionResult FuelCalculate(FuelviewModel model)
        {
        if(model.Fuelmodel != null && model.Fuelmodel.Distance !=0)
         {
            model.Fuelmodel.AgComsumption =
           _buisnessLogic.CalculateAvgConsumption(model.Fuelmodel.Fuel, model.Fuelmodel.Distance);
            model.ShowResult =true;
            return View("FuelCalculate", model);
          }
             model.ShowResult = false;
                ViewBag.Error = "Blédne Dane";
           return View("FuelCalculate", model);
        }
    

     }
}