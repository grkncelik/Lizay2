using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Threading.Tasks;
using PushSharp.Google;
using PushSharp.Apple;

namespace Lizay.crm
{
    public partial class DenetimOdulu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CurrentUser.USERNAME == "")
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            else
            {
                if (!IsPostBack)
                {

                    LoadMagaza();

                }
            }
        }

        void LoadMagaza()
        {
            try
            {
                ClearMessageBox();
                dropMagaza.Items.Clear();
                dropMagaza.Items.Add(new ListItem() { Value = "", Text = "Seçiniz" });

                List<dll.entity.COMPANY> magaza;

                magaza = Lizay.dll.method.COMPANY.Get_CompanyList("");

                foreach (var item in magaza)
                {
                    dropMagaza.Items.Add(new ListItem() { Value = item.COMPANY_NO, Text = item.COMPANY_NAME });
                }
            }
            catch (Exception ex)
            {
                ShowWarningBox(ex.Message);
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ClearMessageBox();


                string Magaza = dropMagaza.SelectedValue;

                Lizay.dll.method.USER_BADGE.AddNewOdul(new dll.entity.USER_BADGE()
                {
                    COMPANY_NO = Magaza,
                    ISACTIVE = true,
                    CREATED_DATE = DateTime.Now,
                    MODIFIED_DATE = DateTime.Now

                });


                string Message = "Yeni bir Denetim Ödülü rozeti kazandınız.";
                string Header = "1 adet görüntülenmeyi bekleyen rozetiniz var!";
                string Url = "http://lizay.btkurumsal.xyz/Rozetler.aspx";
                var RegistrationIdListAndroid = Lizay.dll.method.USERS.Get_UserList("", "", "MUDUR", "", "", "1", Magaza);
                var RegistrationIdListIOS = Lizay.dll.method.USERS.Get_UserList("", "", "", "MUDUR", "", "2", Magaza);
                if (RegistrationIdListAndroid.Count > 0)
                {
                    AndroidSend(RegistrationIdListAndroid, Message, Header, Url);
                }

                if (RegistrationIdListIOS.Count > 0)
                {
                    IosSend(RegistrationIdListIOS, Message, Header, Url);
                }

                ShowInfoBox("Denetim Ödülü başarıyla eklendi.");

            }
            catch (Exception ex)
            {
                ShowWarningBox(ex.Message);
            }
        }


        private void AndroidSend(List<Lizay.dll.entity.USERS> users, string Message, string Header, string Url)
        {
            var task = Task.Factory.StartNew(
            state =>
            {
                var context = (HttpContext)state;
                var token = ConfigurationManager.AppSettings["GoogleKeyForParent"];
                if (users.Count <= 0)
                    return;
                var config = new GcmConfiguration("", token, null);
                var gcmBroker = new GcmServiceBroker(config);
                gcmBroker.Start();


                foreach (var item in users)
                {
                    // Queue a notification to send
                    gcmBroker.QueueNotification(new GcmNotification
                    {
                        RegistrationIds = new List<string> {
                                item.DEVICE_ID
                        },
                        Data = JObject.Parse("{\"alert\":\"" + Message + "\",\"badge\":0,\"sound\":\"sound.caf\",\"Header\":\"" + Header + "\",\"Text\":\"" + Message + "\",\"Url\":\"" + Url + "\"}")
                    });
                }

                gcmBroker.Stop();
            }, HttpContext.Current);
        }


        private void IosSend(List<Lizay.dll.entity.USERS> users, string Message, string Header, string Url)
        {
            //var task = Task.Factory.StartNew(
            //state =>
            //{
            var context = HttpContext.Current;
            if (users.Count <= 0)
                return;
            var pass = ConfigurationManager.AppSettings["IosCerPass"];
            var path = string.Empty;

            if (HttpRuntime.AppDomainAppId != null)
            {
                path = context.Server.MapPath("~/Cer/" + "ios.p12");
            }
            else
            {
                path = @"C:\inetpub\wwwroot\lizayapp\Cer\ios.p12";
            }

            var config = new ApnsConfiguration(ApnsConfiguration.ApnsServerEnvironment.Production, path, pass)
            {


            };
            var apnsBroker = new ApnsServiceBroker(config);

            apnsBroker.Start();

            apnsBroker.OnNotificationFailed += (notification, aggregateEx) =>
            {

                aggregateEx.Handle(ex =>
                {

                    // See what kind of exception it was to further diagnose
                    if (ex is ApnsNotificationException)
                    {
                        var notificationException = (ApnsNotificationException)ex;

                        // Deal with the failed notification
                        var apnsNotification = notificationException.Notification;
                        var statusCode = notificationException.ErrorStatusCode;

                        Console.WriteLine($"Apple Notification Failed: ID={apnsNotification.Identifier}, Code={statusCode}");

                    }
                    else
                    {
                        // Inner exception might hold more useful information like an ApnsConnectionException			
                        Console.WriteLine($"Apple Notification Failed for some unknown reason : {ex.InnerException}");
                    }

                    // Mark it as handled
                    return true;
                });
            };

            foreach (var item in users)
            {
                //var badge = MessageUtils.GetUnReadedMessages(item) + MessageUtils.GetUnreadedContactMessage(item);
                var badge = 0;

                apnsBroker.QueueNotification(new ApnsNotification
                {
                    DeviceToken = item.DEVICE_ID,
                    //Payload = JObject.Parse("{\"aps\":{\"badge\":1,\"Header\":\"" + model.Header + "\",\"Text\":\"" + model.Message + "\",\"Url\":\"" + model.Url + "\"}}")
                    Payload = JObject.Parse("{\"aps\":{\"alert\":\"" + Message + "\",\"badge\":\"" + badge + "\",\"sound\":\"default\",\"Header\":\"" + Header + "\",\"Text\":\"" + Message + "\",\"Url\":\"" + Url + "\"}}")
                });


            }
            apnsBroker.Stop();
            //},
            //HttpContext.Current);
        }

        public void ClearMessageBox()
        {
            ltWarningBox.Text = "";
            MessageBox.Visible = false;
        }

        public void ShowWarningBox(string Message)
        {
            MessageBox.CssClass = "WarningBox";
            ltWarningBox.Text = Message;
            MessageBox.Visible = true;
        }

        public void ShowInfoBox(string Message)
        {
            MessageBox2.CssClass = "InfoBox";
            ltWarningBox2.Text = Message;
            MessageBox2.Visible = true;
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}