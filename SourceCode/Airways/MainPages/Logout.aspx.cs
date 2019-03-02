using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airways
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session.Abandon();
            }
            catch (Exception)
            {
                Response.Redirect("ErrorPage.aspx");
            }
           
            
        }
    }
}