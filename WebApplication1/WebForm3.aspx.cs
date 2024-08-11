using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
   
    public partial class WebForm3 : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database2.mdf;Integrated Security=True");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into [Message] values('"+ TextBox1.Text+"', '"+TextBox2.Text+"')",con);
            cmd.ExecuteNonQuery();

            con.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            
        }
    }
}