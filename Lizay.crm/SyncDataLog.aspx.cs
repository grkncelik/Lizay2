using System;
using System.Configuration;
using Lizay.dll.CaniasWS;
using Newtonsoft.Json.Linq;

namespace Lizay.crm
{
    public partial class SyncDataLog : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var list = dll.method.Log.GetLastLog();
                var mailTemplate = "";
                foreach (var t in list)
                {
                    mailTemplate += t.LogDate + " - " + t.Title + " - " + t.Description;
                }

                MailGonder(mailTemplate);
            }
            catch (Exception ex)
            {
                // MailGonder("Test");
            }

        }

        void MailGonder(string log)
        {
            try
            {
                var fromMail = ConfigurationSettings.AppSettings["FromMailAdress"];
                var toMailAdress = ConfigurationSettings.AppSettings["ToMailAdress"];
                var credentials = ConfigurationSettings.AppSettings["Credentials"];
                var credentialsPass = ConfigurationSettings.AppSettings["CredentialsPass"];
                var port = ConfigurationSettings.AppSettings["Port"];

                var email = new System.Net.Mail.MailMessage();

                email.From = new System.Net.Mail.MailAddress(fromMail);
                var toMailAdressArray = toMailAdress.Split(';');
                
                foreach (string t in toMailAdressArray)
                {
                    email.To.Add(t);
                }


                email.Subject = "Lizay App Senk. Log";
                email.Body = "Log : " + log;
                email.IsBodyHtml = true;

                var client = new System.Net.Mail.SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(credentials, credentialsPass);
                client.Port = Convert.ToInt32(port);
                client.Host = ConfigurationSettings.AppSettings["Host"];
                client.EnableSsl = false;
                client.Send(email);
            }
            catch (Exception e)
            {
                return;
            }
        }

    }
}