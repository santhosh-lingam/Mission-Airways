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
    public class DAProfile
    {
        public static void ProfileUpdate(string CusID, string CusName, string CusMail, string CusDOB, string CusAdrs, string CusPhone, string CusGender, out int Status)
        {
            try
            {
                string ConStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                Database db = new SqlDatabase(ConStr);
                using (DbCommand dbcmd = db.GetStoredProcCommand("CustomerProfileUpdate_SP"))
                {



                    db.AddInParameter(dbcmd, "@Cus_Name", DbType.String, CusName);
                    db.AddInParameter(dbcmd, "@Cus_Mail", DbType.String, CusMail);
                    db.AddInParameter(dbcmd, "@Cus_DOB", DbType.String, CusDOB);
                    db.AddInParameter(dbcmd, "@Cus_Address", DbType.String, CusAdrs);
                    db.AddInParameter(dbcmd, "@Cus_Phone", DbType.String, CusPhone);
                    db.AddInParameter(dbcmd, "@Cus_Geneder", DbType.String, CusGender);
                    db.AddInParameter(dbcmd, "@Cus_ID", DbType.String, CusID);


                    db.AddOutParameter(dbcmd, "@Status", DbType.Int32, 255);

                    db.ExecuteNonQuery(dbcmd);


                    Status = Convert.ToInt32(db.GetParameterValue(dbcmd, "@Status"));
                }
                
                
                //SqlConnection con = new SqlConnection(ConStr);

                //con.Open();
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = con;
                //cmd.CommandText = "CustomerProfileUpdate";
                //cmd.CommandType = CommandType.StoredProcedure;

                //SqlParameter sp02 = cmd.Parameters.Add("@CName", SqlDbType.VarChar, 50);
                //SqlParameter sp03 = cmd.Parameters.Add("@CMail", SqlDbType.VarChar, 50);
                //SqlParameter sp05 = cmd.Parameters.Add("@CDOB", SqlDbType.VarChar, 50);
                //SqlParameter sp06 = cmd.Parameters.Add("@CAddress", SqlDbType.VarChar, 200);
                //SqlParameter sp07 = cmd.Parameters.Add("@CPhone", SqlDbType.BigInt, 50);
                //SqlParameter sp08 = cmd.Parameters.Add("@CGeneder", SqlDbType.VarChar, 50);
                //SqlParameter sp01 = cmd.Parameters.AddWithValue("@Cus_ID", CusID);
                //SqlParameter stat = cmd.Parameters.Add("@Status", SqlDbType.Int);

                //stat.Direction = ParameterDirection.Output;


                //sp02.Value = CusName;
                //sp03.Value = CusMail;
                //sp05.Value = CusDOB;
                //sp06.Value = CusAdrs;
                //sp07.Value = CusPhone;
                //sp08.Value = CusGender;

                //cmd.ExecuteNonQuery();

                //status = Convert.ToInt32(stat.Value.ToString());
                //con.Close();
            }
            catch (SqlException Excptn_ProfileUpdate)
            {
                throw Excptn_ProfileUpdate;
            }

        }
    }
}
