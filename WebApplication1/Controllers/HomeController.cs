using DayScheduling.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using DayScheduling.BLL;
using DayScheduling.Entities.Activity;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BLLActivity bll = new BLLActivity();
            vmActivitiyEntities Model = bll.GetvmActivities();
            return View(Model);
        }
        public ActionResult DeleteActivity()
        {
            BLLActivity bll = new BLLActivity();
            bll.DeleteActivity(1010);
            return RedirectToAction("Index");
        }

        public ActionResult MainPage()
        {
            return View();
        }

        public ActionResult LoginPage()
        {
            return View();
        }
        public ActionResult myPlans()
        {
            return View();
        }
        public ActionResult viewPlan()        
            {
                return View();
            }
            public ActionResult Places()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
       }
    }
