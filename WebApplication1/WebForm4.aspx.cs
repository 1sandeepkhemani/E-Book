using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
             HyperLink1.NavigateUrl = "Scripts/ass.iwp.pdf";
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                sendemail();
                Response.Redirect("main.aspx");
            }

            catch (Exception)
            {
                Label1.Text = "not send";
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
            mail.Body = ("Dear, "+TextBox1.Text.Trim() + Environment.NewLine + Environment.NewLine + TextBox3.Text.Trim());
            smtp_Client.Port = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["smtpPort"]);
            smtp_Client.Credentials = new System.Net.NetworkCredential(smtpUserName, smtpPassword);
            smtp_Client.EnableSsl = Convert.ToBoolean(System.Configuration.ConfigurationSettings.AppSettings["enableSSL"]);
            smtp_Client.Send(mail);
        }
    }
}