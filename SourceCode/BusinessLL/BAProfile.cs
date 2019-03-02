using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BAProfile
    {
        public static void ProfileUpdate( string CusID,string CusName,string  CusMail,string  CusDOB, string  CusAdrs, string  CusPhone, string  CusGender,out int Status)
        {
            try
            {
                DAProfile.ProfileUpdate(CusID, CusName, CusMail, CusDOB, CusAdrs, CusPhone, CusGender, out Status);

            }
            catch (Exception Excptn_ProfileUpdate)
            {
                throw Excptn_ProfileUpdate;
            }
        }

    }
}
