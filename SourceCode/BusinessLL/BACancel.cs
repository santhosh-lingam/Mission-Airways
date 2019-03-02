using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BACancel
    {
        public static void BusinessCancel(double Booking_ID, out int Status, out int Refund_Amount, int CusID)
        {
            try
            {

                DACancel.DataCancel(Booking_ID, out Status, out Refund_Amount, CusID);
            }
            catch (Exception Excptn_BusinessCancel)
            {
                throw Excptn_BusinessCancel;
            }
        }

        public static void BusinessLogic()
        {

        }
    }
}
