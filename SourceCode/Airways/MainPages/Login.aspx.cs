using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BALogIn;
using System.IO;

namespace Airways
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = UserName_TextBox.Text;
                string Pass = Pass_TextBox.Text;

                int Status = BusinessClass.LoginValidationB(UserName, Pass);
                if (Status == 1)
                {
                    Session["User_Name"] = UserName_TextBox.Text.ToString();
                    Response.Redirect("Home.aspx");

                }
                else
                {
                    Alert_Label.ForeColor = System.Drawing.Color.Red;
                    Alert_Label.Text = "Username Or Password Invalid";
                }
            }
            catch (Exception Excptn_Login)
            {

                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + Excptn_Login.Message + "<br/>" + Environment.NewLine + Environment.NewLine +
                                     "StackTrace :" + Excptn_Login.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + Excptn_Login.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }

                Exception_Label.Text = "Please Enter The Data In Correct Format";

            }


        }
    }
}