using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BABookingHistory
    {
        public static DataTable BookingHistory(string CusID)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = DABookingHistory.BookingHistory(CusID);
                return dt;
            }
            catch (Exception Excptn_BookingHistory)
            {
                throw Excptn_BookingHistory;
            }
        }
    }
}
