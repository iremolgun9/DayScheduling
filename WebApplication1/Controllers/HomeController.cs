using DayScheduling.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using DayScheduling.BLL;
using DayScheduling.Entities.Activity;
using DayScheduling.Entities.Plan;
using DayScheduling.Entities.Account;
using JsAction;

namespace WebApplication1.Controllers
{

    public class HomeController : Controller
    {
        BLLActivity bllAct = new BLLActivity();
        BLLAccount bllAcc = new BLLAccount();
        BLLPlan bllPlan = new BLLPlan();

        public ActionResult Index()
        {
            if (Session["Account"] == null)// Siteye İlk girişte Index sayfasında sessionı açıp değerii sıfır yapıyoruz yani logout durumda.
            {
                Session.Add("Account", "0");
            }
            else if (Session["Account"].ToString() == "1")
            {
                return RedirectToAction("UserPage","Home"); // Loginse Userpage'e git
            }
            return View();
        }
        [DSAuthorize]
        public ActionResult UserPage()
        {
            vmUserPage model = new vmUserPage();
            model.PlanBlockList = bllPlan.GetPlanBlockList(AccountUser.Account.AccountID,true);
            return View(model);
        }
        public ActionResult LogOut()
        {
            AccountUser.isLogined = false;
            Session.Remove("Account");
            return RedirectToAction("Index","Home");
        }
    }
    }
