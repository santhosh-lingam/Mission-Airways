using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;


namespace BusinessAccessLayer
{
    public class BASearch
    {
        public static DataTable SearchB(string From, string To, string Date, DateTime Time, int Seats)
        {
            try
            {

                DataTable dt = new DataTable();
                return dt = DASearch.SearchD(From, To, Date, Time, Seats);
            }
            catch (Exception Excptn_SearchB)
            {
                throw Excptn_SearchB;
            }

        }

        public static float BookAmount(float Amount, int Passengers)
        {
            float FinalAmount= Amount * Passengers;
            return FinalAmount;

        }
    }
}