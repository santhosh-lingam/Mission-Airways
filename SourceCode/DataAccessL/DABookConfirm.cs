using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.IO;

namespace DataAccessLayer
{
    public class DABookConfirm
    {
        public static double BookConfirmData(double CusID, string CusName, string DateOfJourney, string FlightID, string AirlineName, string Source_Loc, string Destination_Loc, string Pass_Count, string Book_Date, string Depart_Time, string Fare, string Total_Fare)
        {
            try
            {
                string ConnectionStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                Database db = new SqlDatabase(ConnectionStr);
                using (DbCommand dbcmd = db.GetStoredProcCommand("BookDetailsConfirm_SP"))
                {

                    db.AddInParameter(dbcmd, "@Cus_ID", DbType.Int32, CusID);
                    db.AddInParameter(dbcmd, "@Cus_Name", DbType.String, CusName);
                    db.AddInParameter(dbcmd, "@Date_Of_Journey", DbType.String, DateOfJourney);
                    db.AddInParameter(dbcmd, "@Flight_ID", DbType.String, FlightID);
                    db.AddInParameter(dbcmd, "@AirlineName", DbType.String, AirlineName);
                    db.AddInParameter(dbcmd, "@Source_Loc", DbType.String, Source_Loc);
                    db.AddInParameter(dbcmd, "@Destination_Loc", DbType.String, Destination_Loc);
                    db.AddInParameter(dbcmd, "@Pass_Count", DbType.String, Pass_Count);
                    db.AddInParameter(dbcmd, "@Book_Date", DbType.String, Book_Date);
                    db.AddInParameter(dbcmd, "@Depart_Time", DbType.String, Depart_Time);
                    db.AddInParameter(dbcmd, "@Fare", DbType.String, Fare);
                    db.AddInParameter(dbcmd, "@Tot_fare", DbType.String, Total_Fare);


                    db.AddOutParameter(dbcmd, "@Booking_ID", DbType.Int32, 255);



                    db.ExecuteNonQuery(dbcmd);

                    int bookid = 0;
                    bookid = Convert.ToInt32(db.GetParameterValue(dbcmd, "@Booking_ID"));

                    return bookid;
                }
            }
            catch (SqlException Excptn_BookConfirmData)
            {
                throw Excptn_BookConfirmData;
            }

        }
    }
}
