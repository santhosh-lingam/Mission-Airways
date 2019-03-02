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
    public class DALogIn
    {
        public static int LoginvalidationD(string UserName, string Pass)
        {
            try
            {
                string ConStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                Database db = new SqlDatabase(ConStr);
                using (DbCommand dbcmd = db.GetStoredProcCommand("LogInValidation_SP"))
                {

                    db.AddInParameter(dbcmd, "@Username", DbType.String, UserName);
                    db.AddInParameter(dbcmd, "@Password", DbType.String, Pass);




                    db.AddOutParameter(dbcmd, "@Status", DbType.Int32, 10);




                    db.ExecuteNonQuery(dbcmd);

                    int Status = 0;

                    Status = Convert.ToInt32(db.GetParameterValue(dbcmd, "@status"));
                    return Status;
              }


            //SqlConnection connect = new SqlConnection(ConStr);


            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.StoredProcedure;
            //command.CommandText = "LogInValidation";
            //command.Connection = connect;


            //command.Parameters.AddWithValue("@username", username);
            //command.Parameters.AddWithValue("@passwrd", pass);
            //SqlParameter param1 = command.Parameters.Add("@status", SqlDbType.TinyInt, 10);

            //param1.Direction = ParameterDirection.Output;
            //connect.Open();
            //command.ExecuteNonQuery();

            //int status = Convert.ToInt32(param1.Value.ToString());
            //connect.Close();
            //return status;

        }
            catch (SqlException Excptn_LoginvalidationD)
            {
                throw Excptn_LoginvalidationD;
            }

}
    }
}
  