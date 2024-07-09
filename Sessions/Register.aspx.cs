using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class Register : System.Web.UI.Page
    {
        //Steps to store webform data to database
        //1.Design UI from
        //2.Apply Validations 
        //3.Create table in database
        //4.Setup connection string in web.config
        //5.Create connection class in back end file
        //6.write ado.net code to store data

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into DBUsers values (@name,@contact,@email,@city,@dt)", con);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@city", ddlCities.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@dt", DateTime.Now.Date);
            con.Open();
            cmd.ExecuteNonQuery();
            txtName.Text = "";
            txtContact.Text=string.Empty;
            txtEmail.Text=string.Empty;
            ddlCities.SelectedIndex = 0;
            Response.Write("<script>alert('Data saved successfully..!')</script>");



        }
    }
}