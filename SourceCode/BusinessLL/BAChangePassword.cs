using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BAChangePassword
    {
        public static int ChangePassword( string OldPass , string NewPass , string ConfirmPass, string CusID)
        {
            try
            {
                int Status = 0;
                Status = DAChangePassword.ChangePassword(OldPass, NewPass, ConfirmPass, CusID);
                return Status;
            }
            catch (Exception Excptn_ChangePassword)
            {
                throw Excptn_ChangePassword;
            }


        }
    }
}
