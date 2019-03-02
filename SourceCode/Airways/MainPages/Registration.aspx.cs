using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessAccessLayer;
using System.IO;
namespace Airways
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Registration_Successful_Label.Visible = false;
            Login_Label.Visible = true;
           
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            try
            {
                string Cus_Name = Name_TextBox.Text;
                string Cus_Username = UN_TextBox.Text;
                string Cus_Mail = EID_TextBox.Text;
                string Cus_Pass = Pass_TextBox.Text;
                string Cus_DOB = DOB_TextBox.Text;
                string Cus_Address = Address_TextBox.Text;
                double Cus_Phone = double.Parse(Phone_TextBox.Text);
                string Cus_Gender = RadioButtonList1.Text;
                string Cus_SSNType = SSN_DropDownList.Text;
                string Cus_SSN = SSN_Type_TextBox.Text;
                int Status = 0;
                 Status = BAReg.RegistrationB(Cus_Name, Cus_Username, Cus_Mail, Cus_Pass, Cus_DOB, Cus_Address, Cus_Phone, Cus_Gender, Cus_SSNType, Cus_SSN);
                if (Status !=0)
                {
                    Registration_Successful_Label.Visible = true;
                    Registration_Successful_Label.Text = "Registration Successfull..!!    ";
                    UserName_Label.Visible = true;
                    UserName_Label.Text = "Username: "+Cus_Username;
                    Login_Label.Visible = true;


                }
                else
                {
                    Registration_Successful_Label.Text = "Please Enter the required fields";

                }
            }
            catch (Exception Excptn_Registration)
            {

                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + Excptn_Registration.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + Excptn_Registration.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + Excptn_Registration.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }
                Login_Label.Visible = false;
                UserName_Label.Visible = false;
              //  Exception_Label.Text = System.Drawing.Color.Red.ToString() ;
                Exception_Label.Text = "Username or SSN is already exists..Please use different Username or SSN Type";

            }
            
        }

      

       
    }
}