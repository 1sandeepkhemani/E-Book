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
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database2.mdf;Integrated Security=True");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("select * from [Table] where email = '" + TextBox1.Text + "'  and password = '" + TextBox2.Text + "' ", con);
            da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Session["uname"] = TextBox1.Text.ToString();
                Response.Redirect("books.aspx");
            }

            else
            {
                Label5.Text = "Invaild!";
            }

            TextBox1.Text = "";
            TextBox2.Text = "";
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("forgetpass.aspx");
        }
    }
    }
