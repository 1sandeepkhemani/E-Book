using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Reflection.Emit;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;

namespace WebApplication1
{
    public partial class signup : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database2.mdf;Integrated Security=True");
        }

     

        protected void Button1_Click1(object sender, EventArgs e)
        {
           
          

            try
            {

                if (TextBox3.Text == "book101use")
                {
                    sendemail();

                    con.Open();
                    cmd = new SqlCommand("insert into [Table] values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();




                    Session["uname"] = TextBox2.Text.ToString();
                    Response.Redirect("newpass.aspx");
                }

                else
                {
                    Label6.Text = "Incorrect Password";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                }
            }

            catch (Exception)
            {
                Label6.Text = "Not Send";
            }
        }

        private void sendemail()
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
            mail.Body = ("Dear, " + TextBox1.Text.Trim() + Environment.NewLine + Environment.NewLine + "We're thrilled to welcome you to E-BOOKS STORE! Your account creation is now complete, and you're ready to explore all that we have to offer."+Environment.NewLine+ Environment.NewLine +"Sincerely"+ Environment.NewLine +"E-BOOKS STORE");
            smtp_Client.Port = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["smtpPort"]);
            smtp_Client.Credentials = new System.Net.NetworkCredential(smtpUserName, smtpPassword);
            smtp_Client.EnableSsl = Convert.ToBoolean(System.Configuration.ConfigurationSettings.AppSettings["enableSSL"]);
            smtp_Client.Send(mail);
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
            mail.Body = ("Dear, " + TextBox1.Text.Trim() + Environment.NewLine + Environment.NewLine + "Your Password :- book101use");
            smtp_Client.Port = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["smtpPort"]);
            smtp_Client.Credentials = new System.Net.NetworkCredential(smtpUserName, smtpPassword);
            smtp_Client.EnableSsl = Convert.ToBoolean(System.Configuration.ConfigurationSettings.AppSettings["enableSSL"]);
            smtp_Client.Send(mail);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            try
            {
                sendpass();
                Label6.Text = "Send";
            }

            catch (Exception)
            {
                Label6.Text = "Not Send";
            }
        }
    }
}