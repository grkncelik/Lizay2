using Lizay.dll.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lizay.dll.CaniasWS;
using Newtonsoft.Json;

namespace Lizay.crm
{
    public partial class urunarama : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "PageLoad", "PageLoad();", true);

            divMessage1.Visible = false;
            divMessage2.Visible = false;
            if (CurrentUser.USERNAME == "")
            {
                FormsAuthentication.RedirectToLoginPage();
            }

            if (!string.IsNullOrEmpty(Page.Request.QueryString["Barcode"]))
            {
                Response.Redirect("UrunDetay.aspx?Barkod=" + Page.Request.QueryString["Barcode"].ToUpper());
                return;
            }

            if (IsPostBack) return;

            LoadDrp1();
        }

        protected void drp1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            drp2.Items.Clear();
            drp3.Items.Clear();
            drp4.Items.Clear();
            drp5.Items.Clear();

            if (drp1.SelectedValue != "")
                LoadDrp2();
        }

        protected void drp2_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            drp3.Items.Clear();
            drp4.Items.Clear();
            drp5.Items.Clear();

            if (drp2.SelectedValue != "")
                LoadDrp3();
        }

        protected void drp3_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            drp4.Items.Clear();
            drp5.Items.Clear();

            if (drp3.SelectedValue != "")
                LoadDrp4();
        }

        protected void drp4_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            drp5.Items.Clear();

            if (drp4.SelectedValue != "")
                LoadDrp5();
        }

        protected void btnUrunAra_OnClick(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBarkod.Text))
            {
                divMessage1.Visible = true;
                return;
            }

            Response.Redirect("UrunDetay.aspx?Barkod=" + txtBarkod.Text);
        }

        private void LoadDrp1()
        {
            drp1.Items.Clear();
            drp1.Items.Insert(0, new ListItem("Seçiniz", ""));
            var sessionId = "";
            var caniasWebService = new iasWebServiceImplService();

            try
            {
                var arg = "1," + CurrentUser.USERNAME;

                sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
                var resp = caniasWebService.callIASService(sessionId, "RetailMatCheck", arg, "STRING", true);

                var json = resp.ToString().Replace("[]", "''").Replace("\"ROW\":", "");
                json = json.Remove(0, 1);
                json = "[" + json;
                json = json.Remove(json.Length - 1, 1);
                json = json + "]";

                var category = JsonConvert.DeserializeObject<List<CategoryViewModel>>(json);

                foreach (var k in category.ToList())
                {
                    drp1.Items.Add(new ListItem(k.Description, k.Value));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }
            finally
            {
                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }
        }

        private void LoadDrp2()
        {

            drp2.Items.Clear();
            drp2.Items.Insert(0, new ListItem("Seçiniz", ""));
            var sessionId = "";
            var caniasWebService = new iasWebServiceImplService();

            try
            {
                var arg = "2," + CurrentUser.USERNAME + "," + drp1.SelectedValue;

                sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
                var resp = caniasWebService.callIASService(sessionId, "RetailMatCheck", arg, "STRING", true);

                var json = resp.ToString().Replace("[]", "''").Replace("\"ROW\":", "");
                json = json.Remove(0, 1);
                json = "[" + json;
                json = json.Remove(json.Length - 1, 1);
                json = json + "]";

                var drp2List = JsonConvert.DeserializeObject<List<DropViewModel>>(json);

                foreach (var k in drp2List.ToList())
                {
                    drp2.Items.Add(new ListItem(k.Description, k.Value));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }
            finally
            {
                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }
        }

        private void LoadDrp3()
        {

            drp3.Items.Clear();
            drp3.Items.Insert(0, new ListItem("Seçiniz", ""));
            var sessionId = "";
            var caniasWebService = new iasWebServiceImplService();

            try
            {
                var arg = "2," + CurrentUser.USERNAME + "," + drp1.SelectedValue + "," + drp2.SelectedValue;

                sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
                var resp = caniasWebService.callIASService(sessionId, "RetailMatCheck", arg, "STRING", true);

                var json = resp.ToString().Replace("[]", "''").Replace("\"ROW\":", "");
                json = json.Remove(0, 1);
                json = "[" + json;
                json = json.Remove(json.Length - 1, 1);
                json = json + "]";

                var drp3List = JsonConvert.DeserializeObject<List<DropViewModel>>(json);

                foreach (var k in drp3List.ToList())
                {
                    drp3.Items.Add(new ListItem(k.Description, k.Value));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }
            finally
            {
                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }
        }

        private void LoadDrp4()
        {

            drp4.Items.Clear();
            drp4.Items.Insert(0, new ListItem("Seçiniz", ""));
            var sessionId = "";
            var caniasWebService = new iasWebServiceImplService();

            try
            {
                var arg = "2," + CurrentUser.USERNAME + "," + drp1.SelectedValue + "," + drp2.SelectedValue + "," + drp3.SelectedValue;

                sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
                var resp = caniasWebService.callIASService(sessionId, "RetailMatCheck", arg, "STRING", true);

                var json = resp.ToString().Replace("[]", "''").Replace("\"ROW\":", "");
                json = json.Remove(0, 1);
                json = "[" + json;
                json = json.Remove(json.Length - 1, 1);
                json = json + "]";

                var drp4List = JsonConvert.DeserializeObject<List<DropViewModel>>(json);

                foreach (var k in drp4List.ToList())
                {
                    drp4.Items.Add(new ListItem(k.Description, k.Value));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }
            finally
            {
                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }
        }

        private void LoadDrp5()
        {

            drp5.Items.Clear();
            drp5.Items.Insert(0, new ListItem("Seçiniz", ""));
            var sessionId = "";
            var caniasWebService = new iasWebServiceImplService();

            try
            {
                var arg = "2," + CurrentUser.USERNAME + "," + drp1.SelectedValue + "," + drp2.SelectedValue + "," + drp3.SelectedValue + "," + drp4.SelectedValue;

                sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
                var resp = caniasWebService.callIASService(sessionId, "RetailMatCheck", arg, "STRING", true);

                var json = resp.ToString().Replace("[]", "''").Replace("\"ROW\":", "");
                json = json.Remove(0, 1);
                json = "[" + json;
                json = json.Remove(json.Length - 1, 1);
                json = json + "]";

                var drp5List = JsonConvert.DeserializeObject<List<DropViewModel>>(json);

                foreach (var k in drp5List.ToList())
                {
                    drp5.Items.Add(new ListItem(k.Description, k.Value));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }
            finally
            {
                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }
        }

        public USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (USERS)Session["USERS"]; return new USERS(); }
        }

        protected void btnUrunleriGetir_OnClick(object sender, EventArgs e)
        {
            var filter = "";

            if (string.IsNullOrEmpty(drp1.SelectedValue))
            {
                divMessage2.Visible = true;
                return;
            }

            filter += "," + drp1.SelectedValue;

            if (!string.IsNullOrEmpty(drp2.SelectedValue))
            {
                filter += "," + drp2.SelectedValue;
            }
            else
            {
                filter += ",";
            }

            if (!string.IsNullOrEmpty(drp3.SelectedValue))
            {
                filter += "," + drp3.SelectedValue;
            }
            else
            {
                filter += ",";
            }

            if (!string.IsNullOrEmpty(drp4.SelectedValue))
            {
                filter += "," + drp4.SelectedValue;
            }
            else
            {
                filter += ",";
            }

            if (!string.IsNullOrEmpty(drp5.SelectedValue))
            {
                filter += "," + drp5.SelectedValue;
            }
            else
            {
                filter += ",";
            }


            Response.Redirect("UrunAramaListe.aspx?Filtre=" + filter);

            //var sessionId = "";
            //var caniasWebService = new iasWebServiceImplService();
            //try
            //{
            //    var arg = "3,IYILMAZ" + filter;

            //    sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
            //    var resp = caniasWebService.callIASService(sessionId, "RetailMatCheck", arg, "STRING", true);

            //    var json = resp.ToString().Replace("[]", "''");

            //    if (string.IsNullOrEmpty(json))
            //    {
            //        if (!string.IsNullOrEmpty(sessionId))
            //            caniasWebService.logout(sessionId);
            //    }

            //    var drp4List = JsonConvert.DeserializeObject<List<DropViewModel>>(json);

            //    foreach (var k in drp4List.ToList())
            //    {
            //        drp4.Items.Add(new ListItem(k.Description, k.Value));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);

            //    if (!string.IsNullOrEmpty(sessionId))
            //        caniasWebService.logout(sessionId);
            //}
            //finally
            //{
            //    if (!string.IsNullOrEmpty(sessionId))
            //        caniasWebService.logout(sessionId);
            //}
        }
    }
}