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
    public class DAPrepaidWallet
    {
        public static void DAWalletBalance(string Name, out string Balance)
        {
            try
            {
                string ConStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                Database db = new SqlDatabase(ConStr);
                using (DbCommand dbcmd = db.GetStoredProcCommand("PrepaidBal_SP"))
                {

                    db.AddInParameter(dbcmd, "@Name", DbType.String, Name);

                    db.AddOutParameter(dbcmd, "@Balance", DbType.String, 100);

                    db.ExecuteNonQuery(dbcmd);

                    Balance = (db.GetParameterValue(dbcmd, "@Balance")).ToString();

                }


                //SqlConnection con2 = new SqlConnection(ConStr);

                //con2.Open();
                //SqlCommand cmd2 = new SqlCommand();
                //cmd2.Connection = con2;
                //cmd2.CommandText = "PrepaidBal";
                //cmd2.CommandType = CommandType.StoredProcedure;
                //cmd2.Parameters.AddWithValue("@name", name);
                //SqlParameter output = cmd2.Parameters.Add("@Balance", SqlDbType.Money);
                //output.Direction = ParameterDirection.Output;

                //cmd2.ExecuteNonQuery();

                //con2.Close();

                //Balance = output.Value.ToString();

            }
            catch (Exception Excptn_DAWalletBalance)
            {
                throw Excptn_DAWalletBalance;
            }
        }
    }
}
             
          
