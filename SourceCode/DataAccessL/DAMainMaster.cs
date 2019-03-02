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
    public class DAMainMaster
    {
        public static void DACustomerData(string CusName, out int Cus_ID, out string CusMail, out string CusDOB, out string CusAddress, out string CusPhone, out string CusGender, out string Bal_Amount)
        {
            try
            {

                string ConStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;


                Database db = new SqlDatabase(ConStr);
                using (DbCommand dbcmd = db.GetStoredProcCommand("CustomerDetailsFetch_SP"))
                {



                    db.AddInParameter(dbcmd, "@Cus_User_Name", DbType.String, CusName);


                    db.AddOutParameter(dbcmd, "@Cus_ID", DbType.Int32, 255);
                    db.AddOutParameter(dbcmd, "@Cus_Mail", DbType.String, 100);
                    db.AddOutParameter(dbcmd, "@Cus_DOB", DbType.String, 100);
                    db.AddOutParameter(dbcmd, "@Cus_Address", DbType.String, 200);
                    db.AddOutParameter(dbcmd, "@Cus_Phone", DbType.String, 100);
                    db.AddOutParameter(dbcmd, "@Cus_Gender", DbType.String, 100);
                    db.AddOutParameter(dbcmd, "@Bal_Amount", DbType.String, 100);


                    db.ExecuteNonQuery(dbcmd);


                    Cus_ID = Convert.ToInt32(db.GetParameterValue(dbcmd, "@Cus_ID"));
                    CusMail = (db.GetParameterValue(dbcmd, "@Cus_Mail")).ToString();
                    CusDOB = (db.GetParameterValue(dbcmd, "@Cus_DOB")).ToString();
                    CusAddress = (db.GetParameterValue(dbcmd, "@Cus_Address")).ToString();
                    CusPhone = (db.GetParameterValue(dbcmd, "@Cus_Phone")).ToString();
                    CusGender = (db.GetParameterValue(dbcmd, "@Cus_Gender")).ToString();
                    Bal_Amount = (db.GetParameterValue(dbcmd, "@Bal_Amount")).ToString();

                }


                //SqlConnection con2 = new SqlConnection(ConStr);

                //con2.Open();
                //SqlCommand cmd2 = new SqlCommand();
                //cmd2.Connection = con2;
                //cmd2.CommandText = "CustomerDetailsFetch";
                //cmd2.CommandType = CommandType.StoredProcedure;
                //SqlParameter sp01 = cmd2.Parameters.Add("@Cus_ID", SqlDbType.Int);
                //SqlParameter sp02 = cmd2.Parameters.Add("@Cus_Mail", SqlDbType.VarChar, 50);
                //SqlParameter sp03 = cmd2.Parameters.Add("@Cus_DOB", SqlDbType.VarChar, 50);
                //SqlParameter sp04 = cmd2.Parameters.Add("@Cus_Address", SqlDbType.VarChar, 50);
                //SqlParameter sp05 = cmd2.Parameters.Add("@Cus_Phone", SqlDbType.VarChar, 50);
                //SqlParameter sp06 = cmd2.Parameters.Add("@Cus_Gender", SqlDbType.VarChar, 50);
                //SqlParameter sp07 = cmd2.Parameters.Add("@Bal_Amount", SqlDbType.Money);
                //SqlParameter check = cmd2.Parameters.AddWithValue("@Check", CusName);


                //sp01.Direction = ParameterDirection.Output;
                //sp02.Direction = ParameterDirection.Output;
                //sp03.Direction = ParameterDirection.Output;
                //sp04.Direction = ParameterDirection.Output;
                //sp05.Direction = ParameterDirection.Output;
                //sp06.Direction = ParameterDirection.Output;
                //sp07.Direction = ParameterDirection.Output;


                //cmd2.ExecuteNonQuery();

                //Cus_ID = Convert.ToInt32(sp01.Value.ToString());
                //CusMail = sp02.Value.ToString();
                //CusDOB = sp03.Value.ToString();
                //CusAddress = sp04.Value.ToString();
                //CusPhone = sp05.Value.ToString();
                //CusGender = sp06.Value.ToString();
                //Bal_Amount = sp07.Value.ToString();
                //con2.Close();
            }
            catch (Exception Excptn_DACustomerData)
            {
                throw Excptn_DACustomerData;
            }

        }
    }
}
