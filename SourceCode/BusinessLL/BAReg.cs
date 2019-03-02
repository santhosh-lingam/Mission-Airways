using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BusinessAccessLayer
{
    public class BAReg
    {

        public static int RegistrationB(string Cus_Name, string Cus_Username, string Cus_Mail, string Cus_Pass, string Cus_DOB, string Cus_Address, double Cus_Phone, string Cus_Gender, string Cus_SSNType, string Cus_SSN)
        {
            try
            {
                int Status = DAReg.RegistrationD(Cus_Name, Cus_Username, Cus_Mail, Cus_Pass, Cus_DOB, Cus_Address, Cus_Phone, Cus_Gender, Cus_SSNType, Cus_SSN);
                return Status;
            }
            catch (Exception Excptn_RegistrationB)
            {
                throw Excptn_RegistrationB;
            }
        }
    
    

    }
}


