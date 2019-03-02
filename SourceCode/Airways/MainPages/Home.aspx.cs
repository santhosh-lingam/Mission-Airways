using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airways
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["User_Name"] == null)
                {
                    Response.Redirect("ErrorPage.aspx");
                }
            }
            catch (Exception)
            {
                Exception_Label.Text = "Website Under Maintenance";
            }
            
        }

        
    }
}