using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using System.Data;
using System.IO;

namespace Airways
{
    public partial class TripHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Name"] == null)
            {
                Response.Redirect("ErrorPage.aspx");
            }
            try
            {
                string CusId = Session["CusID"].ToString();

                DataTable dt = new DataTable();

                dt = BABookingHistory.BookingHistory(CusId);
                if (dt.Rows.Count!=0)
                {
                    Trips_GridView.DataSource = dt;
                    Trips_GridView.DataBind();
                }
                else
                {
                    TripsStatus_Label.Visible = true;
                    TripsStatus_Label.Text = "No Data Available";
                }
            }
            catch (Exception Excptn_TripHistory)
            {


                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + Excptn_TripHistory.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + Excptn_TripHistory.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + Excptn_TripHistory.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }
                
                Exception_Label.Text = "Data Not Found";
            }
        }
    }
}