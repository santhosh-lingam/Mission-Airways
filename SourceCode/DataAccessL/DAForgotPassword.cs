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
   public class DAForgotPassword
    {

        public static int ForgotPassword(string SSN_Type, string SS_Number, string ConfirmPass)
        {
            try
            {
                string ConStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;


                Database db = new SqlDatabase(ConStr);
                using (DbCommand dbcmd = db.GetStoredProcCommand("ForgotPassword_SP"))
                {

                    db.AddInParameter(dbcmd, "@SSN_Type", DbType.String, SSN_Type);
                    db.AddInParameter(dbcmd, "@SS_Number", DbType.String, SS_Number);
                    db.AddInParameter(dbcmd, "@Confirm_Pass", DbType.String, ConfirmPass);



                    db.AddOutParameter(dbcmd, "@Status", DbType.Int32, 255);




                    db.ExecuteNonQuery(dbcmd);

                    int Status = 0;

                    Status = Convert.ToInt32(db.GetParameterValue(dbcmd, "@Status"));
                    return Status;
                }


                //SqlConnection Con = new SqlConnection(ConStr);

                //SqlCommand cmd = new SqlCommand();

                //cmd.Connection = Con;
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandText = "CustomerPasswordUpdate";

                //Con.Open();
                //cmd.Parameters.AddWithValue("@C_Old_Pass", OldPass);
                //cmd.Parameters.AddWithValue("@C_New_Passs", NewPass);
                //cmd.Parameters.AddWithValue("@Cus_ID", CusID);
                //SqlParameter output = cmd.Parameters.Add("@Status", SqlDbType.Int);

                //output.Direction = ParameterDirection.Output;


                //cmd.ExecuteNonQuery();

                //int status = 0;

                //status = Convert.ToInt32(output.Value.ToString());

                //Con.Close();

                //return status;
            }

            catch (SqlException Excptn_ChangePassword)
            {
                throw Excptn_ChangePassword;
            }
        }
    }
}

