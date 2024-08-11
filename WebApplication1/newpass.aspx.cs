using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class newpass : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database2.mdf;Integrated Security=True");
            if (Session["uname"] != null)
            {
                TextBox1.Text = Session["uname"].ToString();
            }

            else
            {

                Response.Redirect("signup.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                sendpass();
                con.Open();
                cmd = new SqlCommand("update [Table] set password='" + TextBox2.Text + "' where email='" + TextBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();



                Label6.Text = "sucessfull";
                Response.Redirect("login.aspx");


            }

            catch (Exception)
            {
                Label6.Text = "Not Send";
            }
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
            mail.To.Add(TextBox1.Text.Trim());
            mail.Subject = "Welcome to E-BOOKS STORE ";
            mail.Body = ("Dear, Sir/Mam " + Environment.NewLine + Environment.NewLine + "Your  Password Change Successfully");
            smtp_Client.Port = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["smtpPort"]);
            smtp_Client.Credentials = new System.Net.NetworkCredential(smtpUserName, smtpPassword);
            smtp_Client.EnableSsl = Convert.ToBoolean(System.Configuration.ConfigurationSettings.AppSettings["enableSSL"]);
            smtp_Client.Send(mail);
        }
    }
}