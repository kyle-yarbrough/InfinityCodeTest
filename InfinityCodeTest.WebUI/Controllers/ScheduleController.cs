using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfinityCodeTest.WebUI.Models;
using InfinityCodeTest.WebUI.Helper;


namespace InfinityCodeTest.WebUI.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Schedule
        public ViewResult Index()
        {

            DeliveryScheduleViewModel model = new DeliveryScheduleViewModel();

            //Generate random data for this project per run
            model.Deliveries = CreateRandomData.GenerateDeliveryData();

            return View(model);
        }
    }
}