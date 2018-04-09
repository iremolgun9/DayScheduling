using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayScheduling.Data
{
    public class DALAccount
    {
        DaySchedulingModelDataModels Models = new DaySchedulingModelDataModels();
        public Account LoginIsSuccess(string UsernameOrEmail,string password)
        {
            string query = @"SELECT * FROM Account A,Users U WHERE A.AccountPassword = @Password AND A.UserID = U.UserID AND U.Email =@Email"; //cilem.akcay@hotmail.com
            var res = Models.Database.SqlQuery<Account>(query,new SqlParameter("@Password",password),new SqlParameter("@Email",UsernameOrEmail));
            return res.FirstOrDefault();
        }
        public void Add()
        {
            //string query = @"";
            //Models.Database.ExecuteSqlCommand();
        }
    }
}