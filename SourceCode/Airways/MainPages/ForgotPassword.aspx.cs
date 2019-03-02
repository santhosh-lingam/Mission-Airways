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
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            LogIn_Label.Visible = true;
            ChangePass_Label.Visible = false;

        }

        protected void ChangePass_Button_Click(object sender, EventArgs e)
        {

            try
            {
                string SSN_Type = SSN_DropDownList.Text;
                string SS_Number = SSN_Type_TextBox.Text;
                string ConfirmPass = ConfirmPass_TextBox.Text;
               

                int Status = 0;
                Status = BAForgotPassword.ForgotPassword(SSN_Type, SS_Number, ConfirmPass);

                if (Status == 1)
                {
                        ChangePass_Label.Visible = true;

                        ChangePass_Label.Text = "Password Changed Successsfully";
                        LogIn_Label.Visible = true;
                }
                else
                {
                    ChangePass_Label.Visible = true;

                    ChangePass_Label.Text = "Incorrect SSN Type Or SSN</br>Try Again";
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