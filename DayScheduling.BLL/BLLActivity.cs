using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayScheduling.Data;
using DayScheduling.Entities.Activity;

namespace DayScheduling.BLL
{
    public class BLLActivity
    {
        DALActivity DALAct = new DALActivity();

        public vmActivitiyEntities GetvmActivities()
        {
            Activity DBactivity = DALAct.Get(0); // controllerdan gelcek.
            vmActivitiyEntities Activities = new vmActivitiyEntities();
            List<vmPartialActivity> partialActivityList = new List<vmPartialActivity>();
            vmPartialActivity activity = new vmPartialActivity();

            activity.ActivityPlaceName = DBactivity.ActivityName;// Placeden çekilip name koyulacak.
            //activity.ActivityPlaceRating = eklenecek.
            //activity.ActivityPlaceCategory = placeden çekilip konulacak.
            //activity.ActivityPrice price eklenecek
            activity.StartTime = DBactivity.ActivityStartTime;
            activity.FinishTime = DBactivity.ActivityFinishTime;
            activity.ActivityPlaceRating = "raitng";
            activity.ActivityPrice = "price";
            activity.ActivityPlaceCategory = "category";
            partialActivityList.Add(activity);
            Activities.Activities = partialActivityList; //Activities.Activities initiliaze edilmeli.
            return Activities; 
        }

        public int DeleteActivity(int ID)
        {
            return DALAct.Delete(ID); //sayfadan gelcek.
        }
    }
}
