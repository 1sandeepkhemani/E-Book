using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Reflection.Emit;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
       
        
        SqlDataAdapter da;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn= new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
           
                    }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
           cmd = new SqlCommand("insert into sonu values('"+ TextBox1.Text+"','"+TextBox2.Text+"')",conn);

            cmd.ExecuteNonQuery();
            conn.Close();
           
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
                conn.Open();
             cmd = new SqlCommand("select * from sonu where email = '"+TextBox3.Text+"'  and pass = '"+TextBox4.Text+"' ",conn);
            da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            { 
                Response.Redirect("Default.aspx");
            }

            else
            {
                Label1.Text = "Invaild ";
            }

            TextBox3.Text = "";
            TextBox4.Text = "";
            conn.Close();
        }
       
      
    }
}