using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayScheduling.Data;

namespace DayScheduling.BLL
{
    public class BLLAccount
    {
        DALAccount dalacc = new DALAccount();
        public bool LoginIsSuccess(string NameOrEmail,string Password)
        {
            return (dalacc.LoginIsSuccess(NameOrEmail, Password) != null);
        }
    }
}
