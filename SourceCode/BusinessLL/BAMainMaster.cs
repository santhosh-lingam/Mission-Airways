using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BAMainMaster 
    {
        public static void BACustomerData(string CusName, out int Cus_ID, out string CusMail, out string CusDOB, out string CusAddress, out string CusPhone, out string CusGender, out string Bal_Amount)
        {
            try
            {
                DAMainMaster.DACustomerData(CusName, out Cus_ID, out CusMail, out CusDOB, out CusAddress, out CusPhone, out CusGender, out Bal_Amount);
            }
            catch (Exception Excptn_BACustomerData)
            {
                throw Excptn_BACustomerData;
            }

        }
    }
}
