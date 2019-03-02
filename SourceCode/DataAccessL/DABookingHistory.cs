using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.IO;


namespace DataAccessLayer
{
    public class DABookingHistory
    {
        public static DataTable BookingHistory(string CusID)
        {
            try
            {
                string ConStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                Database dbs = new SqlDatabase(ConStr);
                using (DbCommand dbcmd = dbs.GetStoredProcCommand("BookingHistory_SP"))
                {

                    dbs.AddInParameter(dbcmd, "@CusID", DbType.String, CusID);
                    DataTable dt = new DataTable();
                    dt = null;
                    dt = dbs.ExecuteDataSet(dbcmd).Tables[0];
                    return dt;


                }


                //SqlConnection Con = new SqlConnection(ConStr);

                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = Con;

                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandText = "BookingHistory";

                //cmd.Parameters.AddWithValue("@CusID", CusID);


                //Con.Open();
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //Con.Close();
                //return dt;

            }
            catch(SqlException Excptn_Bookinghistory)
            {
                throw Excptn_Bookinghistory;
            }

        }
    }
}
