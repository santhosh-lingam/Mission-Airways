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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Name"] == null)
            {
                Response.Redirect("ErrorPage.aspx");
            }
        }

        protected void ChangePass_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string OldPass = OldPass_TextBox.Text;
                string NewPass = NewPass_TextBox.Text;
                string ConfirmPass = ConfirmPass_TextBox.Text;
                string CusID = Session["CusId"].ToString();

                int Status = 0;
                Status = BAChangePassword.ChangePassword(OldPass, NewPass, ConfirmPass, CusID);

                if (Status == 1)
                {
                    ChangePass_Label.Text = "Password Changed Successsfully";
                }
                else
                {
                    ChangePass_Label.Text = "Please Enter The Old Password Correctly";
                }
            }
            catch (Exception Excptn_ChangePassword)
            {

                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + Excptn_ChangePassword.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + Excptn_ChangePassword.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + Excptn_ChangePassword.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }

                ChangePass_Label.Text = "Please Enter The Data In Correct Format";
            }          
            
            

        }

    }
}