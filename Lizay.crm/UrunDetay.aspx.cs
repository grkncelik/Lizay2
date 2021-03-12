using Lizay.dll.CaniasWS;
using Lizay.dll.entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class UrunDetay : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (CurrentUser.USERNAME == "")
            {
                FormsAuthentication.RedirectToLoginPage();
            }

            if (IsPostBack) return;

            if (string.IsNullOrEmpty(Page.Request.QueryString["Barkod"])) Response.Redirect("urunarama.aspx");

            var barcodeData = Page.Request.QueryString["Barkod"];

            if (string.IsNullOrEmpty(barcodeData)) Response.Redirect("urunarama.aspx");

            var sessionId = "";
            List<BarcodeViewModel> barcode;
            var caniasWebService = new iasWebServiceImplService();

            try
            {
                //var arg = "IYILMAZ," + barcodeData;
                var arg = CurrentUser.USERNAME + "," + barcodeData;

                sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
                var resp = caniasWebService.callIASService(sessionId, "RetailBatchCheck", arg, "STRING", true);

                var json = resp.ToString().Replace("[]", "''").Replace("\"ROW\":", "");
                json = json.Remove(0, 1);
                json = "[" + json;
                json = json.Remove(json.Length - 1, 1);
                json = json + "]";

                barcode = JsonConvert.DeserializeObject<List<BarcodeViewModel>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);

                return;
            }
            finally
            {
                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }

            switch (barcode)
            {
                case null:
                    return;
                case List<BarcodeViewModel> list:
                    {
                        var mainProduct = list.SingleOrDefault(x => x.IsTp == "1");
                        if (mainProduct == null) Response.Redirect("urunarama.aspx");
                        var alternativeProduct = list.Where(x => x.IsTp == "0").ToList();

                        CreateHtmlMainProduct(mainProduct);
                        CreateHtmlAlternativeProduct(alternativeProduct);
                        break;
                    }
            }
        }

        private void CreateHtmlMainProduct(BarcodeViewModel mainProduct)
        {
            var sbPictureMain = new StringBuilder();
            sbPictureMain.AppendLine("<ul id=\"image-gallery\" class=\"gallery list-unstyled cS-hidden\" > ");

            //Birden fazla resim olursa for döngüsü olacak
            //foreach (var VARIABLE in COLLECTION)
            //{
            sbPictureMain.AppendLine("<li data-thumb=\"https://www.lizaypirlanta.com/resim/urun/lizay-pirlanta-baget-yuzukler-DR31254-1568017816-1.jpg\" class=\"fotog\">");
            sbPictureMain.AppendLine("<img src=\"data:image/png;base64," + mainProduct.Picture.Replace("-----BEGIN CERTIFICATE-----", "").Replace("-----END CERTIFICATE-----", "") + "\" class=\"fotoga\" alt =\"\" />");
            sbPictureMain.AppendLine("</li>");
            //}

            sbPictureMain.AppendLine(" </ul>");
            ltMainProductPicture.Text = sbPictureMain.ToString();

            var sb = new StringBuilder();
            sb.AppendLine("<span class=\"urunkodu col-lg-12 col-xs-12\">" + mainProduct.Barcode.Trim() + "</span>");
            sb.AppendLine("<span class=\"urunadi col-lg-12 col-xs-12\">" + mainProduct.DetColor.Trim().ToUpper() + "</span>");
            //Gürkan Düzenlenecek
            sb.AppendLine("<div class=\"col-lg-7 col-xs-12\" style=\"margin-top: 15px;\">");
            sb.AppendLine("<div class=\"sol\" style=\"font-size:20px;\" > Liste Fiyatı:</div><p class=\"sag ustucizik\" style =\"font-weight:bold;font-size:25px;\">" + mainProduct.Sprice.Trim() + " TL</p>");
            sb.AppendLine("</div>");
            sb.AppendLine("<div class=\"col-lg-7 col-xs-12\" style=\"margin-top:15px;\">");
            sb.AppendLine("<div class=\"sol\" style=\"font-size:20px;\"> Fiyat:</div><p class=\"sag\" style =\"font-size:23px;font-weight:bold;color:red;\">" + mainProduct.Lastprice.Trim() + " TL</p>");
            sb.AppendLine("</div>");

            if (!string.IsNullOrEmpty(mainProduct.Campaing.Trim()))
            {
                sb.AppendLine("<div class=\"col-lg-7 col-xs-12\" style=\"margin-top:15px;\">");
                sb.AppendLine("<div class=\"sol\">Kampanya Tipi:</div><p class=\"sag\">" + mainProduct.Campaing.Trim() + "</p>");
                sb.AppendLine("</div>");
            }

            sb.AppendLine("<div class=\"col-lg-7 col-xs-12\" style=\"margin-top:15px;\">");
            sb.AppendLine("<div class=\"sol\">Taş Özellikleri:</div><p class=\"sag\">" + mainProduct.IsTasDet.Trim() + "</p>");
            sb.AppendLine("</div>");
            sb.AppendLine("<div class=\"col-lg-7 col-xs-12\" style=\"margin-top:15px;\">");
            sb.AppendLine("<div class=\"sol\">Ağırlık:</div><p class=\"sag\">" + mainProduct.QuantityX.Trim() + "gr</p>");
            sb.AppendLine("</div>");
            sb.AppendLine("<div class=\"col-lg-6 col-xs-12\" style=\"margin-top:15px;\">");
            sb.AppendLine("<div class=\"sol\">E:</div><p class=\"sag ustucizik\">" + mainProduct.Mameti.Trim() + "</p>");
            sb.AppendLine("</div>");
            //sb.AppendLine("<div class=\"col-lg-6 col-xs-12\" style=\"margin-top:15px;\">");
            //sb.AppendLine("<div class=\"sol\">Maliyet Kuru:</div><p class=\"sag\">" + mainProduct.Costcurrency.Trim() + "</p>");
            //sb.AppendLine("</div>");
            sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style=\"margin-top:15px;\">");
            sb.AppendLine("<div class=\"sol\">Bulunduğu Mağaza:</div><p class=\"sag\">" + mainProduct.IsWare.Trim() + "</p>");
            sb.AppendLine("</div>");
            //////////


            //sb.AppendLine("<div class=\"col-lg-7 col-xs-12\" style=\"margin-top: 15px;\">");
            //sb.AppendLine("<div class=\"sol\">Taş:</div>");
            //sb.AppendLine("<p class=\"sag\">" + mainProduct.IsMatText.Trim() + "</p>");
            //sb.AppendLine("</div>");

            //sb.AppendLine("<div class=\"col-lg-7 col-xs-12\" style=\"margin-top: 15px; \">");
            //sb.AppendLine("<div class=\"sol\">Taş Özellikleri:</div>");
            //sb.AppendLine("<p class=\"sag\">" + mainProduct.IsTasDet.Trim() + "</p>");
            //sb.AppendLine("</div>");

            //sb.AppendLine("<div class=\"col-lg-5 col-xs-12\" style=\"margin -top: 15px; \" > ");
            //sb.AppendLine("<div class=\"sol\" > Montür:</div>");
            //sb.AppendLine("<p class=\"sag\" > " + mainProduct.DetColor.Trim() + "</p>");
            //sb.AppendLine("</div>");

            //sb.AppendLine("<div class=\"col-lg-7 col-xs-12\" style=\"margin-top: 15px; \" > ");
            //sb.AppendLine("<div class=\"sol\" > Ağırlık:</div>");
            //sb.AppendLine("<p class=\"sag\" > " + mainProduct.QuantityX.Trim() + "gr</p>");
            //sb.AppendLine("</div>");

            //sb.AppendLine("<div class=\"col-lg-5 col-xs-12\" style=\"margin-top: 15px; \" > ");
            //sb.AppendLine("<div class=\"sol\" > Kesim:</div>");
            //sb.AppendLine("<p class=\"sag\" > " + mainProduct.IsMatText.Trim() + "</p>");
            //sb.AppendLine("</div>");

            //sb.AppendLine("<div class=\"col-lg-7 col-xs-12\" style=\"margin-top: 15px; \" > ");
            //sb.AppendLine("<div class=\"sol\" > Fiyat:</div>");
            //sb.AppendLine("<p class=\"sag\" > " + mainProduct.Lastprice.Trim() + " TL</p>");
            //sb.AppendLine("</div>");

            //sb.AppendLine("<div class=\"col-lg-5 col-xs-12\" style=\"margin-top: 15px; \" > ");
            //sb.AppendLine("<div class=\"sol\" > Son Satılamaz Kuru:</div>");
            //sb.AppendLine("<p class=\"sag\" >" + mainProduct.Spricecurrency.Trim() + "</p>");
            //sb.AppendLine("</div>");

            //sb.AppendLine("<div class=\"col-lg-7 col-xs-12\" style=\"margin-top: 15px; \" > ");
            //sb.AppendLine("<div class=\"sol\" > Etiket:</div>");
            //sb.AppendLine("<p class=\"sag ustucizik\" > " + mainProduct.Mameti.Trim() + "</p>");
            //sb.AppendLine("</div>");

            //sb.AppendLine("<div class=\"col-lg-5 col-xs-12\" style=\"margin-top: 15px; \" > ");
            //sb.AppendLine("<div class=\"sol\" > Maliyet Kuru:</div>");
            //sb.AppendLine("<p class=\"sag\" >" + mainProduct.Costcurrency.Trim() + "</p>");
            //sb.AppendLine("</div>");

            //sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style=\"margin-top: 15px; \" > ");
            //sb.AppendLine("<div class=\"sol\" > Bulunduğu Mağaza:</div>");
            //sb.AppendLine("<p class=\"sag\" > " + mainProduct.IsWare.Trim() + "</p>");
            //sb.AppendLine("</div>");

            ltMainProduct.Text = sb.ToString();
        }

        private void CreateHtmlAlternativeProduct(List<BarcodeViewModel> alternativeProduct)
        {
            var sb = new StringBuilder();

            sb.AppendLine("<div class=\"row\" style=\"margin-top: 30px;\">");
            foreach (var p in alternativeProduct)
            {
                sb.AppendLine("<div class=\"col-lg-4 col-sm-4 col-md-4 col-xs-12\" style=\"margin-top: 30px;\">");

                sb.AppendLine("<div class=\"col-lg-12\">");
                sb.AppendLine("<img src=\"data:image/png;base64," + p.Picture.Replace("-----BEGIN CERTIFICATE-----", "").Replace("-----END CERTIFICATE-----", "") + "\" class=\"img-responsive shadow\" alt =\"\" />");
                sb.AppendLine("</div>");

                sb.AppendLine("<div class=\"col-lg-12 col-xs-12\" style=\"margin-top: 15px; margin-bottom:7px;\"> ");
                sb.AppendLine(p.IsMatText.Trim() + " " + p.IsTasDet.Trim() + " " + p.DetColor.Trim());
                sb.AppendLine("</div>");

                //sb.AppendLine("<div class=\"col-lg-12 col-xs-12\">");
                //sb.AppendLine("<div class=\"sol1\"> Taş:</div>");
                //sb.AppendLine("<p class=\"sag1\"> " + p.IsMatText.Trim() + "</p>");
                //sb.AppendLine("</div>");

                sb.AppendLine("<div class=\"col-lg-12 col-xs-12\">");
                sb.AppendLine("<div class=\"sol1\">Taş Özellikleri:</div>");
                sb.AppendLine("<p class=\"sag1\">" + p.IsTasDet.Trim() + "</p>");
                sb.AppendLine("</div>");

                sb.AppendLine("<div class=\"col-lg-12 col-xs-12\">");
                sb.AppendLine("<div class=\"sol1\">Barkod:</div>");
                sb.AppendLine("<p class=\"sag1\">" + p.Barcode.Trim() + "</p>");
                sb.AppendLine("</div>");

                //sb.AppendLine("<div class=\"col-lg-12 col-xs-12\"> ");
                //sb.AppendLine("<div class=\"sol1\"> Montür:</div>");
                //sb.AppendLine("<p class=\"sag1\">" + p.DetColor.Trim() + "</p>");
                //sb.AppendLine("</div>");

                sb.AppendLine("<div class=\"col-lg-12 col-xs-12\">");
                sb.AppendLine("<div class=\"sol1\"> Ağırlık:</div>");
                sb.AppendLine("<p class=\"sag1\">" + p.QuantityX.Trim() + "gr</p>");
                sb.AppendLine("</div>");

                //sb.AppendLine("<div class=\"col-lg-12 col-xs-12\">");
                //sb.AppendLine("<div class=\"sol1\"> Kesim:</div>");
                //sb.AppendLine("<p class=\"sag1\">" + p.IsMatText.Trim() + "</p>");
                //sb.AppendLine("</div>");

                sb.AppendLine("<div class=\"col-lg-12 col-xs-12\"> ");
                sb.AppendLine("<div class=\"sol1\"> Fiyat:</div>");
                sb.AppendLine("<p class=\"sag1\">" + p.Lastprice.Trim() + " TL</p>");
                sb.AppendLine("</div>");

                //sb.AppendLine("<div class=\"col-lg-12 col-xs-12\"> ");
                //sb.AppendLine("<div class=\"sol1\"> Son Satılamaz Kuru:</div>");
                //sb.AppendLine("<p class=\"sag1\">" + p.Spricecurrency.Trim() + "</p>");
                //sb.AppendLine("</div>");

                sb.AppendLine("<div class=\"col-lg-12 col-xs-12\"> ");
                sb.AppendLine("<div class=\"sol1\"> E:</div>");
                sb.AppendLine("<p class=\"sag1 ustucizik\"> " + p.Mameti.Trim() + "</p>");
                sb.AppendLine("</div>");

                sb.AppendLine("<div class=\"col-lg-12 col-xs-12\">");
                sb.AppendLine("<div class=\"sol1\"> Bulunduğu Mağaza:</div>");
                sb.AppendLine("<p class=\"sag1\">" + p.IsWare.Trim() + "</p>");
                sb.AppendLine("</div>");

                //sb.AppendLine("<div class=\"col-lg-12 col-xs-12\">");
                //sb.AppendLine("<div class=\"sol1\"> Maliyet Kuru:</div>");
                //sb.AppendLine("<p class=\"sag1\">" + p.Costcurrency.Trim() + "</p>");
                //sb.AppendLine("</div>");

                sb.AppendLine("</div>");

            }

            sb.AppendLine("</div>");
            ltAlternativeProduct.Text = sb.ToString();
        }


        public USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (USERS)Session["USERS"]; return new USERS(); }
        }
    }
}