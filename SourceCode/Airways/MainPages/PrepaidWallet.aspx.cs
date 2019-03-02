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
    public partial class PrepaidWallet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Name"] == null)
            {
                Response.Redirect("ErrorPage.aspx");
            }
            try
            {
                Username_Label.Text = Session["User_Name"].ToString();
                string Name = Username_Label.Text;
                string Balance = string.Empty;

                BAPrepaidWallet.BAWalletBalance(Name, out Balance);
                PrepaidWallet_Label.Text = " ₹ " + Balance.ToString();
            }
            catch (Exception Excptn_PrepaidWallet)
            {
                string filePath = @"H:\Xpert's Zone\Mission Airways\ErrorLog.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + Excptn_PrepaidWallet.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + Excptn_PrepaidWallet.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + Excptn_PrepaidWallet.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }

                Exception_Label.Text = "Data Not Found";

            }


        }
    }
}