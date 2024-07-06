using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class Q2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtName.Text = Request.QueryString["name"];
            //txtContact.Text = Request.QueryString["contact"];

            txtName.Text = Request.QueryString[0];
            txtContact.Text = Request.QueryString[1];
        }
    }
}