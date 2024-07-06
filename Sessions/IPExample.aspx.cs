using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class IPExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                bindddl();
            }
            
        }

        protected void bindddl()
        {
            ListItem li1 = new ListItem("Kolhapur");
            ddlcity.Items.Add(li1);

            ListItem li2 = new ListItem("Pune");
            ddlcity.Items.Add(li2);

            ListItem li3 = new ListItem("Mumbai");
            ddlcity.Items.Add(li3);

            ListItem li4 = new ListItem("Delhi");
            ddlcity.Items.Add(li4);
        }

        protected void btnrefresh_Click(object sender, EventArgs e)
        {

        }
    }
}