using DayScheduling.Entities.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PlanController : Controller
    {
        public ActionResult PlanCriterias()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DetermineActivity(pmPlanCriteria param)
        {
            return RedirectToAction("DayByDay", "Home");
        }
    }
}