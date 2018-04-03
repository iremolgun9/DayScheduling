using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DayScheduling.Data
{
    public class DALActivity
    {
        DaySchedulingModelDataModels Models = new DaySchedulingModelDataModels();
        public class denemview
        {
            string type { get; set; }
            int rate { get; set; }
            int price { get; set; }
        }

        public Activity Get(int ID)
        {
            List<Activity> actList = Models.Activities.ToList();
            GetPlaceTypeFromPlaceID(actList.ElementAt(ID).ActivityPlaceID);
            return actList.ElementAt(ID);
        }
        public List<Activity> GetList()
        {
            return Models.Activities.ToList();
        }
        public int Delete(int ActivityID)
        {
            var ID = ActivityID;
            var sql = @"DELETE FROM Activity WHERE ActivityID=@activityID";
            return (Models.Database.ExecuteSqlCommand(sql,new SqlParameter("@activityID", ID)));
        }

        public string GetPlaceTypeFromPlaceID(int ID)
        {
            var Id = ID;
            string sql = @"SELECT PT.PlaceType,P.PlaceRate,P.PlacePrice FROM PlaceType PT, Place P WHERE P.PlaceTypeID = PT.PlaceTypeID AND P.PlaceID = @PlaceID";
            /*var rs = Models.Database.SqlQuery<string>("SELECT PlaceType FROM Place").ToList();*/
            var result = Models.Database.SqlQuery<denemview>(sql, new SqlParameter("@PlaceID",Id)).ToList().FirstOrDefault();
            //Models.Database.ExecuteSqlCommand(result.ToString());
            return result.ToString();
        }
    }
}
