using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Airways
{
    public partial class Book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Name"] == null)
            {
                Response.Redirect("ErrorPage.aspx");
            }
            try
            {
            CustomerName_Label.Text = Session["User_Name"].ToString();
            DateOfJourney_Label.Text = Session["Date_journey"].ToString();
            FlightID_Label.Text = Session["flight_id"].ToString();
            AirlineName_Label.Text = Session["Airline_Name"].ToString();
            LeavingFrom_Label.Text = Session["Source_Loc"].ToString();
            GoingTo_Label.Text = Session["Destiantion_Loc"].ToString();
            NoofPassengers_Label.Text = Session["No_Passengers"].ToString();
            BookingDate_Label.Text = DateTime.Now.ToString("dd-MM-yyyy");
            DepartTime_Label.Text = Session["Departure_time"].ToString();
            Fare_Label.Text = Session["fare"].ToString();
            TotalFare_Label.Text = Session["FinalAmount"].ToString();
            }
            catch (Exception Excptn_Book)
            {

                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + Excptn_Book.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + Excptn_Book.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + Excptn_Book.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }
                Exception_Label.Text = "Data Not Found";

            }


        }             
         

        protected void ProceedBook_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookConfirmation.aspx");
        }

        protected void Cancel_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx");
        }
    }
}