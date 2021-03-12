using Lizay.dll.CaniasWS;
using Lizay.dll.entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI;

namespace Lizay.crm
{
    public partial class UrunAramaListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            if (CurrentUser.USERNAME == "")
            {
                FormsAuthentication.RedirectToLoginPage();
            }

            if (IsPostBack) return;

            if (string.IsNullOrEmpty(Page.Request.QueryString["Filtre"])) Response.Redirect("urunarama.aspx");

            var filter = Page.Request.QueryString["Filtre"];
            if (string.IsNullOrEmpty(filter)) Response.Redirect("urunarama.aspx");

            ActiveSession.ActiveUrunFilter = filter;
            var s = GetData(1);
            divLoadData.InnerHtml = s;
        }

        [WebMethod]
        public static string GetData(int pageIndex)
        {

            var sessionId = "";
            var caniasWebService = new iasWebServiceImplService();
            var sb = new StringBuilder();
            try
            {
                var a = pageIndex * 10;
                var countFilter = "";
                if (pageIndex == 1)
                {
                    countFilter = "1," + a;
                }

                if (pageIndex > 1)
                {
                    countFilter = (a + 1) + "," + (a + 10);
                }

                //var arg = "3,IYILMAZ,AMML,,,,,,1,10";
                //var arg = "3,IYILMAZ,AMML,,,,,," + countFilter;
                //var arg = "3,IYILMAZ,ALYM,AU,AL,05,1,10";
                var arg = "3," + ActiveSession.ActiveUserName + ActiveSession.ActiveUrunFilter + "," + countFilter;

                sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
                var resp = caniasWebService.callIASService(sessionId, "RetailMatCheck", arg, "STRING", true);

                var json = resp.ToString().Replace("[]", "''").Replace("\"ROW\":", "");
                json = json.Remove(0, 1);
                json = "[" + json;
                json = json.Remove(json.Length - 1, 1);
                json = json + "]";

                var list = JsonConvert.DeserializeObject<List<BarcodeListViewModel>>(json);

                var i = 0;
                foreach (var d in list.ToList())
                {
                    sb.AppendLine("<div class=\"row\">");
                    sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style = \"margin-top: 15px;border-bottom: groove;\">");
                    sb.AppendLine("<div class=\"col-lg-3 col-xs-6\"> ");
                    sb.AppendLine("<img src=\"data:image/png;base64," + d.Pict.Replace("-----BEGIN CERTIFICATE-----", "").Replace("-----END CERTIFICATE-----", "") + "\" class=\"img-responsive\" alt =\"\" />");
                    sb.AppendLine("</div>");
                    sb.AppendLine("<div class=\"col-lg-9 col-xs-6\"> ");

                    //sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\">");
                    //sb.AppendLine("<div class=\"urunlistsol\">Taş:</div>");
                    //sb.AppendLine("<p class=\"urunlistsag\">" + d.IsMatText.Trim() + "</p>");
                    //sb.AppendLine("</div>");

                    sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\">");
                    sb.AppendLine("<div class=\"urunlistsol\">Taş Özellikleri:</div>");
                    sb.AppendLine("<p class=\"urunlistsag\">" + d.IsTasDet.Trim() + "</p>");
                    sb.AppendLine("</div>");

                    sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\">");
                    sb.AppendLine("<div class=\"urunlistsol\">Barkod:</div>");
                    sb.AppendLine("<p class=\"urunlistsag\">" + d.Batch.Trim() + "</p>");
                    sb.AppendLine("</div>");

                    sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\">");
                    sb.AppendLine("<div class=\"urunlistsol\"> Montür:</div>");
                    sb.AppendLine("<p class=\"urunlistsag\">" + d.DetColor.Trim() + "</p>");
                    sb.AppendLine("</div>");

                    sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\"> ");
                    sb.AppendLine("<div class=\"urunlistsol\">Ağırlık:</div>");
                    sb.AppendLine("<p class=\"urunlistsag\">" + d.QuantityX.Trim() + "gr</p>");
                    sb.AppendLine("</div>");

                    //sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\"> ");
                    //sb.AppendLine("<div class=\"urunlistsol\">Kesim:</div>");
                    //sb.AppendLine("<p class=\"urunlistsag\">" + d.IsMatText.Trim() + "</p>");
                    //sb.AppendLine("</div>");

                    sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\"> ");
                    sb.AppendLine("<div class=\"urunlistsol\">Fiyat:</div>");
                    sb.AppendLine("<p class=\"urunlistsag\">" + d.Lastprice.Trim() + "</p>");
                    sb.AppendLine("</div>");

                    sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\"> ");
                    sb.AppendLine("<div class=\"urunlistsol\">Fiyat Kuru:</div>");
                    sb.AppendLine("<p class=\"urunlistsag\">" + d.Spricecurrency.Trim() + "</p>");
                    sb.AppendLine("</div>");

                    sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\" > ");
                    sb.AppendLine("<div class=\"urunlistsol\">E:</div>");
                    sb.AppendLine("<p class=\"urunlistsag ustucizik\"> " + d.Mameti.Trim() + "</p>");
                    sb.AppendLine("</div>");

                    //sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\">");
                    //sb.AppendLine("<div class=\"urunlistsol\"> Maliyet Kuru:</div>");
                    //sb.AppendLine("<p class=\"urunlistsag\">" + d.Costcurrency.Trim() + "</p>");
                    //sb.AppendLine("</div>");

                    sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style =\"margin-top: 10px;\">");
                    sb.AppendLine("<div class=\"urunlistsol\"> Bulunduğu Mağaza:</div>");
                    sb.AppendLine("<p class=\"urunlistsag\">" + d.IsWare.Trim() + "</p>");
                    sb.AppendLine("</div>");

                    sb.AppendLine("</div>");
                    sb.AppendLine("</div>");
                    sb.AppendLine("</div>");



                    //if (i > 10)
                    //    break;

                    i++;
                }

                return sb.ToString();
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

            return "";
        }



        //[WebMethod]
        //public static string GetCustomers(int pageIndex)
        //{
        //    var s = "";
        //    try
        //    {
        //        s= GetData(pageIndex).GetXml();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);

        //    }

        //    return s;
        //}

        //static DataSet GetData(int pageIndex)
        //{
        //    var sessionId = "";
        //    var caniasWebService = new iasWebServiceImplService();

        //    try
        //    {
        //        var arg = "3,IYILMAZ,ALYM,AU,AL,05";

        //        sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
        //        var resp = caniasWebService.callIASService(sessionId, "RetailMatCheck", arg, "STRING", true);

        //        var json = resp.ToString().Replace("[]", "''").Replace("\"ROW\":", "");
        //        json = json.Remove(0, 1);
        //        json = "[" + json;
        //        json = json.Remove(json.Length - 1, 1);
        //        json = json + "]";

        //        var list = JsonConvert.DeserializeObject<List<BarcodeListViewModel>>(json);
        //        DataTable dt = ToDataTable(list);
        //        DataSet ds = new DataSet();
        //        ds.Tables.Add(dt);

        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);

        //        if (!string.IsNullOrEmpty(sessionId))
        //            caniasWebService.logout(sessionId);
        //    }
        //    finally
        //    {
        //        if (!string.IsNullOrEmpty(sessionId))
        //            caniasWebService.logout(sessionId);
        //    }

        //    return null;
        //}

        //public static DataTable ToDataTable<T>(IList<T> data)
        //{
        //    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
        //    DataTable table = new DataTable();
        //    foreach (PropertyDescriptor prop in properties)
        //        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        //    foreach (T item in data)
        //    {
        //        var row = table.NewRow();
        //        foreach (PropertyDescriptor prop in properties)
        //            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
        //        table.Rows.Add(row);
        //    }
        //    return table;
        //}


        public USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (USERS)Session["USERS"]; return new USERS(); }
        }
    }
}