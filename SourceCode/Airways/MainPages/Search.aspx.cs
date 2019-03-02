using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using BusinessAccessLayer;
using System.IO;


namespace Airways
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User_Name"] == null)
            {
                Response.Redirect("ErrorPage.aspx");
            }
            Book_Button.Visible = false;

        }


        protected void Search1_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string From = City_DropDownList1.Text;
                string To = City_DropDownList2.Text;
                DateTime Cur_Date = DateTime.Now;
                string depart_date = Date_TextBox.Text;                
                string Date = DateTime.ParseExact(depart_date, "dd-MM-yyyy", null).ToString("yyyy-MM-dd");
                DateTime Entered_Date = Convert.ToDateTime(Date);
                Session["Date_journey"] = Date.ToString();
                DateTime Time = DateTime.ParseExact(Time_TextBox.Text, "HH:mm", null);


                Date_Label.Visible = false;
                Seat_Label.Visible = false;
                NoFlight_Label.Visible = false;
                Exception_Label.Visible = false;
                Balance_Label.Visible = false;

                int count = 0;
                int Seats = Convert.ToInt32(Seats_TextBox.Text);
                if (Entered_Date <= Cur_Date)
                {
                   
                    count++;
                    Date_Label.Visible = true;                    
                    Date_Label.Text = "Not allowed to enter past date";
                }
                
                if (Seats > 20)
                {
                    Book_Button.Visible = false;
                    Search_GridView.Visible = false;                             //Seats more than 20 validation
                    Seat_Label.Visible = true;
                    Seat_Label.Text = "Not allowed to book more than 20 tickets";
                }

                else if (Seats <= 0)
                {
                    Book_Button.Visible = false;
                    Search_GridView.Visible = false;                            //Seats Less or equal zero validation
                    Seat_Label.Visible = true;
                    Seat_Label.Text = "Please enter valid number of seat";
                }
                Session["No_Passengers"] = Seats.ToString();

                DataTable dt = new DataTable();

                dt = BASearch.SearchB(From, To, Date, Time, Seats);


                if (dt != null && Seats <= 20 && Seats > 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        Book_Button.Visible = false;
                        Exception_Label.Visible = false;
                       
                        Search_GridView.Visible = true;
                        Search_GridView.DataSource = dt;
                        Search_GridView.DataBind();

                    }
                    else if (City_DropDownList1.SelectedValue == "--Select--")
                    {
                        Search_GridView.Visible = false;
                        NoFlight_Label.Visible = true;
                        NoFlight_Label.Text = "Please select city";
                    }
                    else if (City_DropDownList2.SelectedValue == "--Select--")
                    {
                        NoFlight_Label.Visible = true;
                        Search_GridView.Visible = false;
                        NoFlight_Label.Text = "Please select city";
                    }
                    else if (City_DropDownList1.SelectedValue == City_DropDownList2.SelectedValue)
                    {
                        Search_GridView.Visible = false;
                        NoFlight_Label.Visible = true;
                        NoFlight_Label.Text = "Please enter the different city name";
                    }

                    else
                    {
                        Book_Button.Visible = false;
                       
                        Search_GridView.Visible = false;
                        NoFlight_Label.Visible = true;
                        if (count == 0)
                        {
                            NoFlight_Label.Text = "No Flights Available... Try for different date";
                        }

                    }

                }

            }
            catch (Exception searchE)
            {

                Book_Button.Visible = false;

                Exception_Label.Visible = true;
                NoFlight_Label.Visible = false;
                Search_GridView.Visible = false;

                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + searchE.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + searchE.StackTrace +  "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString()+
                                     "Source :" + searchE.Source + "<br/>" + Environment.NewLine);
                                     writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------"  + Environment.NewLine);
                                    

                }
                
               Exception_Label.Text = "Please Enter Valid Data";

            }




        }


        protected void rbSelector_CheckedChanged(object sender, System.EventArgs e)
        {

            foreach (GridViewRow oldrow in Search_GridView.Rows)
            {
                ((RadioButton)oldrow.FindControl("Book_RadioButton")).Checked = false;

            }

            RadioButton rb = (RadioButton)sender;
            GridViewRow row = (GridViewRow)rb.NamingContainer;
            ((RadioButton)row.FindControl("Book_RadioButton")).Checked = true;

            Book_Button.Visible = true;


        }



        protected void Book_Button_Click(object sender, EventArgs e)
        {
            try
            {

                Date_Label.Visible = false;
                Seat_Label.Visible = false;
                NoFlight_Label.Visible = false;
                Exception_Label.Visible = false;
                Balance_Label.Visible = false;
                for (int i = 0; i < Search_GridView.Rows.Count; i++)
                {
                    RadioButton rb = (RadioButton)Search_GridView.Rows[i]
                                    .Cells[1].FindControl("Book_RadioButton");
                    if (rb != null)
                    {
                        if (rb.Checked)
                        {

                            Session["flight_id"] = Search_GridView.Rows[i].Cells[0].Text;
                            Session["Airline_Name"] = Search_GridView.Rows[i].Cells[1].Text;
                            Session["Source_Loc"] = (Search_GridView.Rows[i].Cells[2].Text);
                            Session["Departure_time"] = Convert.ToDateTime(Search_GridView.Rows[i].Cells[3].Text).ToShortTimeString();
                            Session["Destiantion_Loc"] = Search_GridView.Rows[i].Cells[4].Text;
                            Session["Arrive_time"] = Convert.ToDateTime(Search_GridView.Rows[i].Cells[5].Text).ToShortTimeString();
                            float amount = float.Parse(Search_GridView.Rows[i].Cells[6].Text);
                            Session["fare"] = amount.ToString();
                            int count = Convert.ToInt32(Session["No_Passengers"].ToString());
                            float final_amount = BASearch.BookAmount(amount, count);
                            Session["FinalAmount"] = final_amount.ToString();
                        }
                    }
                }


                Double Bal_Check = Convert.ToDouble(Session["Bal"]);
                Double Flight_Fare = Convert.ToDouble(Session["FinalAmount"]);
                if (Bal_Check >= Flight_Fare)
                {
                    Response.Redirect("Book.aspx");
                }
                else
                {
                    Search_GridView.Visible = false;
                    Balance_Label.Visible = true;
                    Balance_Label.Text = "Oops... Running Low Balance</br>Load money in Jio wallet and try again !!!!";
                }
            }
            catch (Exception searchE)
            {

                Book_Button.Visible = false;

                Exception_Label.Visible = true;
           
                Search_GridView.Visible = false;


                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + searchE.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + searchE.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + searchE.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }
                

                Exception_Label.Text = "No Data Found";

            }


        }





    }

}
