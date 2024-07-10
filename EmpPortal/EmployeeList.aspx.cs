using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpPortal
{
    public partial class EmployeeList : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"]!=null)
            {
                gvdata.DataSource = getEmployeeList();
                gvdata.DataBind();  
            }
            else
            {
                Response.Redirect("AdminLogin.aspx");
            }
        }

        protected DataSet getEmployeeList()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from EmpRegister order by Srno DESC", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);   
            return ds;
        }


    }
}