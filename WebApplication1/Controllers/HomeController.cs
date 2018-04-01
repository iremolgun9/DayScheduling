using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Class1 c = new Class1(1,"KONAAK");
            c.Description = "BLA BLA DESCRIPTION";
            c.Cost = "1,051";
            c.StartTime = "10.30am";
            c.FinishTime = "11.30";
            return View(c);
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
