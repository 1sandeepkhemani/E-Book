using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace WebApplication1
{
    public partial class forgetpass : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database2.mdf;Integrated Security=True");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from [Table] where email = '" + TextBox2.Text + "' ", con);
            da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                sendpass();
                Label6.Text = "Send";
            }

            else
            {
                Label6.Text = "Not Account Found";
            }


            con.Close();
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from [Table] where email = '" + TextBox2.Text + "' ", con);
            da = new SqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0 && TextBox3.Text == "bookfor101")
            {
                Session["uname"] = TextBox2.Text.ToString();
                Response.Redirect("newpass.aspx");
            }

            else
            {
                Label6.Text = "Not Found ";
            }

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            con.Close();
        }

        private void sendpass()
        {
            string smtpUserName;
            string smtpPassword;


            MailMessage mail = new MailMessage();
            SmtpClient smtp_Client = new SmtpClient(System.Configuration.ConfigurationSettings.AppSettings["smtpClient"]);

            smtpUserName = System.Configuration.ConfigurationSettings.AppSettings["smtpUserName"];
            smtpPassword = System.Configuration.ConfigurationSettings.AppSettings["smtpPassword"];
            mail.From = new MailAddress(smtpUserName);
            mail.To.Add(TextBox2.Text.Trim());
            mail.Subject = "Welcome to E-BOOKS STORE ";
            mail.Body = ("Dear, " + TextBox1.Text.Trim() + Environment.NewLine + Environment.NewLine + "Your OTP :- bookfor101");
            smtp_Client.Port = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["smtpPort"]);
            smtp_Client.Credentials = new System.Net.NetworkCredential(smtpUserName, smtpPassword);
            smtp_Client.EnableSsl = Convert.ToBoolean(System.Configuration.ConfigurationSettings.AppSettings["enableSSL"]);
            smtp_Client.Send(mail);
        }
    }
}