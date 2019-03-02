using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration.Assemblies;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.IO;



namespace DataAccessLayer
{
    public class DAReg
    {
        public static int RegistrationD(string Cus_Name, string Cus_Username, string Cus_Mail, string Cus_Pass, string Cus_DOB, string Cus_Address, double Cus_Phone, string Cus_Gender, string Cus_SSNType, string Cus_SSN)
        {
            try
            {
                string ConStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                Database db = new SqlDatabase(ConStr);
                using (DbCommand dbcmd = db.GetStoredProcCommand("Customer_Registration_SP"))
                {



                    db.AddInParameter(dbcmd, "@Cus_Name", DbType.String, Cus_Name);
                    db.AddInParameter(dbcmd, "@Cus_UName", DbType.String, Cus_Username);
                    db.AddInParameter(dbcmd, "@Cus_Mail", DbType.String, Cus_Mail);
                    db.AddInParameter(dbcmd, "@Cus_Pass", DbType.String, Cus_Pass);
                    db.AddInParameter(dbcmd, "@Cus_DOB", DbType.String, Cus_DOB);
                    db.AddInParameter(dbcmd, "@Cus_Address", DbType.String, Cus_Address);
                    db.AddInParameter(dbcmd, "@Cus_Phone", DbType.String, Cus_Phone);
                    db.AddInParameter(dbcmd, "@Cus_Geneder", DbType.String, Cus_Gender);
                    db.AddInParameter(dbcmd, "@Cus_SSNType", DbType.String, Cus_SSNType);
                    db.AddInParameter(dbcmd, "@Cus_SSN", DbType.String, Cus_SSN);

                    


                    int Status = db.ExecuteNonQuery(dbcmd);

                    return Status;
                }
                //string s = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                //SqlConnection connect = new SqlConnection(s);

                //SqlCommand command = new SqlCommand();
                //command.CommandType = CommandType.StoredProcedure;
                //command.CommandText = "CustomerReg";
                //command.Connection = connect;

                //command.Parameters.AddWithValue("@CName", name);
                //command.Parameters.AddWithValue("@CUName", username);
                //command.Parameters.AddWithValue("@CMail", email);
                //command.Parameters.AddWithValue("@CPass", pass);
                //command.Parameters.AddWithValue("@CDOB", dob);
                //command.Parameters.AddWithValue("@CAddress", address);
                //command.Parameters.AddWithValue("@CPhone", phone);
                //command.Parameters.AddWithValue("@CGeneder", ugender);
                //command.Parameters.AddWithValue("@CSSNType", ssnt);
                //command.Parameters.AddWithValue("@CSSN", ssn);
                                
                //connect.Open();
                //var status = command.ExecuteNonQuery();

                //connect.Close();
                //return status;
            }

            catch (SqlException Excptn_RegistrationD)
            {
                throw Excptn_RegistrationD;
            }

        }
    }
}