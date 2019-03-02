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
    public partial class Profile : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Name"] == null)
            {
                Response.Redirect("ErrorPage.aspx");
            }
            try
            {

                if (!IsPostBack)
                {

                    Cus_ID_TextBox.Text = Session["CusID"].ToString();

                    Name_TextBox.Text = Session["User_Name"].ToString();
                    Mail_TextBox.Text = Session["CusMail"].ToString();

                    DOB_TextBox.Text = Session["CusDOB"].ToString();
                    Address_TextBox.Text = Session["CusAdrs"].ToString();
                    Phone_TextBox.Text = Session["CusPhone"].ToString();
                    Gender_TextBox.Text = Session["CusGender"].ToString();
                    RecordUpdated_Label.Visible = false;
                    NotUsed_Label.Visible = false;
                    Update_Button.Visible = false;

                }

                Cus_ID_TextBox.Enabled = false;
                Name_TextBox.ReadOnly = true;
                Mail_TextBox.ReadOnly = true;
                DOB_TextBox.ReadOnly = true;
                Address_TextBox.ReadOnly = true;
                Phone_TextBox.ReadOnly = true;
                DOB_TextBox.ReadOnly = true;
                Gender_TextBox.ReadOnly = true;
                RecordUpdated_Label.Visible = false;
                Update_Button.Visible = false;
            }
            catch (Exception Excptn_Profile)
            { 

                //Response.Redirect("ErrorPage.aspx");
                RecordUpdated_Label.Text = Excptn_Profile.Message.ToString();
            }

        }
        

        protected void Edit_Button_Click1(object sender, EventArgs e)
        {
            Cus_ID_TextBox.ReadOnly = true;
            Name_TextBox.ReadOnly = false;
            Mail_TextBox.ReadOnly = false;           
            DOB_TextBox.ReadOnly = false;
            Address_TextBox.ReadOnly = false;
            Phone_TextBox.ReadOnly = false;
            DOB_TextBox.ReadOnly = false;
            Gender_TextBox.ReadOnly = false;
            RecordUpdated_Label.Visible = false;
            Update_Button.Visible = true;
            Edit_Button.Visible = false;
        }

        protected void Update_Button_Click1(object sender, EventArgs e)
        {
            try
            {
                string CusID = Cus_ID_TextBox.Text;
                string CusName = Name_TextBox.Text;
                string CusMail = Mail_TextBox.Text;
                string CusDOB = DOB_TextBox.Text;
                string CusAdrs = Address_TextBox.Text;
                string CusPhone = Phone_TextBox.Text;
                string CusGender = Gender_TextBox.Text;
                int Status = 0;

                Update_Button.Visible = false;
                Edit_Button.Visible = true;


                BAProfile.ProfileUpdate(CusID, CusName, CusMail, CusDOB, CusAdrs, CusPhone, CusGender, out Status);



                if (Status == 1)
                {
                    NotUsed_Label.Visible = false;
                    RecordUpdated_Label.Visible = true;
                    RecordUpdated_Label.Text = "Record Updated Succesfully";


                }
                else
                {
                    RecordUpdated_Label.Visible = true;
                    RecordUpdated_Label.Text = "Failed to Update";

                }
            }
            catch (Exception Excptn_Profile)
            {
                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + Excptn_Profile.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + Excptn_Profile.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + Excptn_Profile.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }
                NotUsed_Label.Visible = true;
                NotUsed_Label.Text = "Please Enter The Valid Data";
            }

        }
    }
}