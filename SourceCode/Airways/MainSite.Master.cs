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
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label_UName.Text = Session["User_Name"].ToString();

                // Input 
                string CusName = Label_UName.Text;

                //Output
                int Cus_ID;
                string CusMail;
                string CusDOB;
                string CusAddress;
                string CusPhone;
                string CusGender;
                string Bal_Amount;


                BAMainMaster.BACustomerData(CusName, out Cus_ID, out CusMail, out CusDOB, out CusAddress, out CusPhone, out CusGender, out Bal_Amount);

                Session["CusID"] = Cus_ID;
                Session["CusMail"] = CusMail;
                Session["CusDOB"] = CusDOB;
                Session["CusAdrs"] = CusAddress;
                Session["CusPhone"] = CusPhone;
                Session["CusGender"] = CusGender;
                Session["Bal"] = Bal_Amount;
            }

            catch (Exception Excptn_MainSite)
            {


                string filePath = @"C:\Users\620465\Desktop\MFRP\Error.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {


                    writer.WriteLine("Message :" + Excptn_MainSite.Message + "<br/>" + Environment.NewLine +
                                     "StackTrace :" + Excptn_MainSite.StackTrace + "" + Environment.NewLine +
                                     "Date :" + Environment.NewLine + DateTime.Now.ToString() +
                                     "Source :" + Excptn_MainSite.Source + "<br/>" + Environment.NewLine);
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);


                }


                Label_UName.Text = "Username or SSN is already exists..Please use different Username or SSN Type";

            }
          
        }

    }
}