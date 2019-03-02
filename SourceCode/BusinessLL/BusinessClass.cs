using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BusinessLL
{
    public class BusinessClass
    {

        public static int LoginValidationB( string username, string pass)
        {
            int status = DataAccessClass.LoginvalidationD(username, pass);
            return status;
        }
        public static int RegistrationB(string username, string email, string pass, string dob, string address, double phone,string ugender,  string ssnt, string ssn  )
        {
            int status = DataAccessClass.RegistrationD( username,  email,  pass,  dob,address, phone,ugender, ssnt,  ssn);
            return status;
        }
        //public static void SearchB(string from , string to , DateTime date, DateTime Time , int seats)
        //{
        //   DataAccessClass.SearchD(from,to,date, Time,seats);
            
        //}


    }
}
