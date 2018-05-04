﻿using DayScheduling.Entities.Activity;
using DayScheduling.Entities.Plan;
using DayScheduling.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DayScheduling.BLL;
using GoogleMaps.LocationServices;

namespace WebApplication1.Controllers
{
    public class PlanController : Controller
    {
        BLLPlan bllplan = new BLLPlan();
        BLLActivity bllact = new BLLActivity();
        public ActionResult PlanCriterias()
        {
            return View();
        }

        [HttpPost]
        [DSAuthorize]
        public ActionResult DayByDay(pmPlanCriteria param)
        {
            vmDayByDayPlan Model = bllplan.GetvmDayByDay(param);
            return View(Model);
        }

        public ActionResult GetPlan()
        {
            vmDayByDayPlan Model = new vmDayByDayPlan();
            if (TempData.Count != 0)
            {
                var model = TempData["ExistPlan"] as vmDayByDayPlan;
                return View(model);
            }
            return View(Model);
        }

        public ActionResult DeleteActivity()
        {
            BLLActivity bll = new BLLActivity();
            bll.DeleteActivity(1009);
            return RedirectToAction("DayByDay");
        }

        public ActionResult PlaceDetail(pmPlaceDetail param)
        {
            vmPlaceDetail model = bllplan.getPlaceDetail(param);
            return View(model);
        }

        [HttpPost]
        public ActionResult GetExistActivity(int ActivityID)
        {
            vmPartialActivity activity =  bllact.GetExistActivity(ActivityID);
            var res = new {PlaceID = activity.place.PlaceID, PlaceName = activity.place.PlaceName, PlaceRate = activity.place.PlaceRate, Activitytype = activity.ActivityPlaceType };
            return Json(res,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ChangeActivity(int ActivityID,int BudgetInfo, int NumOfFriends, string PlaceType, int ProvinceID, string Popularity)
        {
            //bllact.DeleteActivity(int.Parse(param.updatePlaceID));
            vmPartialActivity existAct =  bllact.GetExistActivity(ActivityID);
            vmPartialActivity newAct =  bllact.GetActivitytoChange(BudgetInfo,NumOfFriends,PlaceType,ProvinceID,Popularity,existAct.StartTime);
            var res = new {activityID= newAct.ActivityID, PlaceID = newAct.place.PlaceID, PlaceName = newAct.place.PlaceName, PlaceRate = newAct.place.PlaceRate, Activitytype = newAct.ActivityPlaceType };
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateActivity(pmUpdateActivity param)
        {
            bllact.DeleteActivity(param.updateActivityID);
            bllact.RecordActivity(param.updateActivityID, param.updateActivityID + "Activity" + AccountUser.Account.AccountID, param.updateActivityTypeSave, true,param.updatePlaceIDSave, param.updatePlanIDSave);
            TempData["ExistPlan"] =  bllplan.GetExistPlan(param.updatePlanIDSave);
            return RedirectToAction("GetPlan","Plan");
        }
    }
}