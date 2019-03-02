using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using System.IO;
namespace Airways.MainPages
{
    public partial class BookConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Name"] == null)
            {
                Response.Redirect("ErrorPage.aspx");
            }
            try
            {
                FinalBookConfirmation_Label.Text = System.Drawing.Color.Green.ToString();
                FinalBookConfirmation_Label.Text = "BOOKED TICKET SUCCESSFULLY.... BOOKING ID ";
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



                string FlightID = Session["flight_id"].ToString();
                double CusID = Convert.ToDouble(Session["CusID"].ToString());
                string CusName = CustomerName_Label.Text;
                string DateOfJourney = DateOfJourney_Label.Text;
                string AirlineName = AirlineName_Label.Text;
                string Source_Loc = LeavingFrom_Label.Text;
                string Destination_Loc = GoingTo_Label.Text;
                string Pass_Count = NoofPassengers_Label.Text;
                string Book_Date = BookingDate_Label.Text;
                string Depart_Time = DepartTime_Label.Text;
                string Fare = Fare_Label.Text;
                string Total_Fare = TotalFare_Label.Text;
               

                double Booking_ID = BABookConfirm.BookConfirmData(CusID, CusName, DateOfJourney, FlightID, AirlineName, Source_Loc, Destination_Loc, Pass_Count, Book_Date, Depart_Time, Fare, Total_Fare);
                FinalBookConfirmation_Label.Text = System.Drawing.Color.Green.ToString();
                FinalBookConfirmation_Label.Text = ".........TICKET BOOKED SUCCESSFULLY......";

                BookingID_Label.Text = Booking_ID.ToString();
            }
            catch (Exception Excptn_BookConfirmation)
            {
                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + Excptn_BookConfirmation.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + Excptn_BookConfirmation.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + Excptn_BookConfirmation.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }
                Exception_Label.Text = "Data Not Found";

            }
        }
    }
}