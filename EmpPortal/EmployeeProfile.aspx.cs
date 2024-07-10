using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpPortal
{
    public partial class EmployeeProfile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"]!=null)
            {
                getEmployeeData();
            }
            else
            {
                Response.Redirect("EmployeeList.aspx");
            }
        }

        protected void getEmployeeData()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from EmpRegister where Srno='" + Request.QueryString["id"] + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                txtName.Text = sdr.GetValue(1).ToString();
                txtEmail.Text = sdr.GetValue(2).ToString();
                txtContact.Text = sdr.GetValue(3).ToString();
                ddldept.SelectedItem.Text = sdr.GetValue(4).ToString();
            }
        }
    }
}