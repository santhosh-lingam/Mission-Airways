using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BABookConfirm
    {
        public static double BookConfirmData(double CusID, string CusName, string DateOfJourney, string FlightID, string AirlineName, string Source_Loc, string Destination_Loc, string Pass_Count, string Book_Date, string Depart_Time, string Fare, string Total_Fare)
        {
            try
            {
                double Booking_ID = DABookConfirm.BookConfirmData(CusID, CusName, DateOfJourney,FlightID, AirlineName, Source_Loc, Destination_Loc, Pass_Count, Book_Date, Depart_Time, Fare, Total_Fare);
                return Booking_ID;
            }
            catch (Exception Excptn_BookConfirmData)
            {
                throw Excptn_BookConfirmData;
            }
        }

    }
}
