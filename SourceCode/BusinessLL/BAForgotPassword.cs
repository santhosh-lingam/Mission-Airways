using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BAForgotPassword
    {

        public static int ForgotPassword(string SSN_Type, string SS_Number, string ConfirmPass)
        {

            try
            {
                int Status = 0;
                Status = DAForgotPassword.ForgotPassword(SSN_Type, SS_Number, ConfirmPass);
                return Status;
            }
            catch (Exception Excptn_ChangePassword)
            {
                throw Excptn_ChangePassword;
            }


        }
    }
}
