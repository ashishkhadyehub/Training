using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpPortal
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"]!=null)
            {
                lilist.Visible= true;
                lilogout.Visible= true;
                lilogin.Visible= false;
            }
            else
            {
                lilist.Visible = false;
                lilogout.Visible = false;
                lilogin.Visible = true;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("AdminLogin.aspx");
        }
    }
}