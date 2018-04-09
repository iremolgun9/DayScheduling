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
        public Activity Get(int ID)
        {
            List<Activity> actList = Models.Activities.ToList();
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
    }
}
