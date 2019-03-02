using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration.Assemblies;


namespace DataAccessLayer
{
    public class DataAccessClass
    {
        public static int LoginvalidationD(string username, string pass)
        {
            //string s =ConfigurationManager
            SqlConnection connect = new SqlConnection(@"Data Source=PC190315\MSSQLSERVER2008;Initial Catalog=MFRP2017;User ID=sa;Password=password1$");
            

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "LogInValidation";
            command.Connection = connect;
            

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@passwrd", pass);
            SqlParameter param1 = command.Parameters.Add("@status", SqlDbType.TinyInt, 10);

            param1.Direction = ParameterDirection.Output;
            connect.Open();
            command.ExecuteNonQuery();

            var status = Convert.ToInt32(param1.Value.ToString());
            connect.Close();
            return status;

            
        }
        public static int RegistrationD(string username, string email, string pass, string dob, string address, double phone,string ugender, string ssnt, string ssn)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=PC190315\MSSQLSERVER2008;Initial Catalog=MFRP2017;User ID=sa;Password=password1$");


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CustomerReg";
            command.Connection = connect;


            command.Parameters.AddWithValue("@CName", username);
            command.Parameters.AddWithValue("@CMail", email);
            command.Parameters.AddWithValue("@CPass", pass);
            command.Parameters.AddWithValue("@CDOB", dob);
            command.Parameters.AddWithValue("@CAddress", address);
            command.Parameters.AddWithValue("@CPhone", phone);
            command.Parameters.AddWithValue("@CGeneder", ugender);
            command.Parameters.AddWithValue("@CSSNType",ssnt);
            command.Parameters.AddWithValue("@CSSN", ssn);
            
           // SqlParameter param1 = command.Parameters.Add("@status", SqlDbType.TinyInt, 10);

            //param1.Direction = ParameterDirection.Output;
            connect.Open();
            var status = command.ExecuteNonQuery();

           // var status = Convert.ToInt32(param1.Value.ToString());
            connect.Close();
            return status;


        }
        //public static void SearchD(string from , string to , DateTime date, DateTime time , int seats)
        //{
        //    //SqlConnection connect = new SqlConnection(@"Data Source=PC190315\MSSQLSERVER2008;Initial Catalog=MFRP2017;User ID=sa;Password=password1$");


        //    //SqlCommand command = new SqlCommand();
        //    //command.CommandType = CommandType.StoredProcedure;
        //    //command.CommandText = "FlightDetails";
        //    //command.Connection = connect;

        //    //connect.Open();
        //    //command.Parameters.AddWithValue("@From", from);
        //    //command.Parameters.AddWithValue("@To", to);
        //    //command.Parameters.AddWithValue("@date", date);
        //    //command.Parameters.AddWithValue("@dep_time", time);
        //    //command.Parameters.AddWithValue("@no_of_seats", seats);

        //    //SqlDataReader rdr = command.ExecuteReader();
        //    //if (rdr.HasRows)
        //    //{
        //    //    GridView1.DataSource = rdr;
        //    //    GridView1.DataBind();
        //    //}
        //    //else
        //    //{
        //    //    Response.Write("No Records Available");
        //    //}

        //    //connect.Close();

        //}





     




        }

    }

