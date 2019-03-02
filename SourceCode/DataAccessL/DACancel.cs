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
    public class DACancel
    {
        public static void DataCancel(double Booking_ID, out int Status, out int Refund_Amount, int CusID)
        {
            try
            {

                string ConStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;


                Database db = new SqlDatabase(ConStr);
                using (DbCommand dbcmd = db.GetStoredProcCommand("CancelBook_SP"))
                {

                    db.AddInParameter(dbcmd, "@Booking_ID", DbType.Int32, Booking_ID);
                    db.AddInParameter(dbcmd, "@Cus_ID", DbType.Int32, CusID);
                    //db.AddInParameter(dbcmd, "@Flight_ID", DbType.String, FlightID);


                    db.AddOutParameter(dbcmd, "@Status", DbType.Int32, 255);
                    db.AddOutParameter(dbcmd, "@Cancel_Amount", DbType.Int32, 255);



                    db.ExecuteNonQuery(dbcmd);

                    Status = Convert.ToInt32(db.GetParameterValue(dbcmd, "@Status"));
                    Refund_Amount = Convert.ToInt32(db.GetParameterValue(dbcmd, "@Cancel_Amount"));
                }


                //SqlConnection con = new SqlConnection(s);

                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = con;

                //cmd.CommandText = "CancelBook";
                //cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@booking_id", booking_id);
                //SqlParameter param1 = cmd.Parameters.Add("@status", SqlDbType.Int, 32);
                //SqlParameter param2 = cmd.Parameters.Add("@cancel_amount", SqlDbType.Int, 32);
                //SqlParameter param3 = cmd.Parameters.AddWithValue("@CusID", CusID);

                //param1.Direction = ParameterDirection.Output;
                //param2.Direction = ParameterDirection.Output;
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                //status = Convert.ToInt32(param1.Value.ToString());
                //amount = Convert.ToInt32(param2.Value.ToString());

            }
            catch (SqlException Excptn_DataCancel)
            {
                throw Excptn_DataCancel;
            }

            
        }
    }
}
