using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration.Assemblies;
using System.Configuration;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;



namespace DataAccessLayer
{
    public class DASearch
    {
        public static DataTable SearchD(string From, string To, string Date, DateTime Time, int Seats)
        {
            try
            {
                string ConStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                Database dbs = new SqlDatabase(ConStr);
                using (DbCommand dbcmd = dbs.GetStoredProcCommand("Search_Flight_SP"))
                {

                    dbs.AddInParameter(dbcmd, "@Leaving_From", DbType.String, From);
                    dbs.AddInParameter(dbcmd, "@Going_To", DbType.String, To);
                    dbs.AddInParameter(dbcmd, "@Departure_Date", DbType.String, Date);
                    dbs.AddInParameter(dbcmd, "@Departure_Time", DbType.String, Time);
                    dbs.AddInParameter(dbcmd, "@Seat", DbType.Int32, Seats);
                    DataTable dt = new DataTable();
                    dt = null;
                    dt = dbs.ExecuteDataSet(dbcmd).Tables[0];
                    return dt;


                }
                //SqlConnection connect = new SqlConnection(s);

                //SqlCommand command = new SqlCommand();
                //command.CommandType = CommandType.StoredProcedure;
                //command.CommandText = "Search_Flight";
                //command.Connection = connect;

                //connect.Open();
                //command.Parameters.AddWithValue("@leaving_from", from);
                //command.Parameters.AddWithValue("@going_to", to);
                //command.Parameters.AddWithValue("@departure_date", date);
                //command.Parameters.AddWithValue("@departure_time", time);
                //command.Parameters.AddWithValue("@seat", seats);

                //SqlDataAdapter sda = new SqlDataAdapter(command);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //connect.Close();
                //return dt;
            }
            catch (Exception Excptn_SearchD)
            {
                throw Excptn_SearchD;                
            }
            
        }
    }
}