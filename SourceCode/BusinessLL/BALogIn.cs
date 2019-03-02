using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;


namespace BALogIn
{
    public class BusinessClass
    {

        public static int LoginValidationB(string UserName, string Pass)
        {
            try
            {
                int Status = DALogIn.LoginvalidationD(UserName, Pass);
                return Status;
            }
            catch (Exception Excptn_LoginValidationB)
            {
                throw Excptn_LoginValidationB;
            }

        }
    }
}