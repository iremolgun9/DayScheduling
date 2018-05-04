using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayScheduling.Data
{
    public class DALUser
    {
        DaySchedulingModelDataModels Models = new DaySchedulingModelDataModels();
        public User Get(int ID)
        {
            string query = @"SELECT * FROM Users WHERE UserID = @ID";
            var res = Models.Database.SqlQuery<User>(query, new SqlParameter("@ID", ID));
            return res.FirstOrDefault();
        }
    }
}
