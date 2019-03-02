using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using System.IO;

namespace Airways
{
    public partial class Cancel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User_Name"] == null)
            {
                Response.Redirect("ErrorPage.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Exception_Label.Visible = false;
                double Booking_ID = Double.Parse(BookingID_TextBox.Text);
                int Status = 0;
                int Refund_Amount = 0;
                int CusID = Convert.ToInt32(Session["CusID"].ToString());
              //  string FlightID = Session["flight_id"].ToString();

                BACancel.BusinessCancel(Booking_ID, out Status, out Refund_Amount, CusID);

                if (Status == 1)
                {
                    Status_Label.Text = "Ticket Cancelled Successfully.   Refund Amount : ₹ " + Refund_Amount;
                }
                else
                {
                    Status_Label.Text = "Booking ID Doesn't Exists";
                }
            }
            catch (Exception Excptn_Cancel)
            {

                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + Excptn_Cancel.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + Excptn_Cancel.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + Excptn_Cancel.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }

                Exception_Label.Visible = true;
                Exception_Label.Text = "Data Not Found";

            }

        }
    }
}