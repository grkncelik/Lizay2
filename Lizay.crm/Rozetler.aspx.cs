using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Text;

namespace Lizay.crm
{
    public partial class Rozetler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CurrentUser.USERNAME == "")
            {
                FormsAuthentication.RedirectToLoginPage();
            }

            if (CurrentUser.USER_TYPE == "FRANCHISE")
            {
                Response.Redirect("urunarama.aspx");
            }

            if (!IsPostBack)
            {
                StringBuilder sb = new StringBuilder();
                if (CurrentUser.USER_TYPE == "PERSONEL")
                {
                    sb.Append(" <h5 class=\"panel-title\" style=\"text-align: center; font-size: 16px; color: White; margin-bottom: 10px; margin-top: 30px;\">En Çok Satan Personel (Hedef Bazında)</h5>");

                    sb.Append("<div class=\"col-lg-12 col-md-12 col-xs-12\" style=\" border: 5px solid #92a7bd; padding-top: 15px; -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7); box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);   margin-bottom: 30px;\">");

                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/goldrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount(CurrentUser.USER_ID, "", 14).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\" style='font-family: fantasy;font-size: 15px;'>1.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/silverrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount(CurrentUser.USER_ID, "", 15).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>2.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/bronzerosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount(CurrentUser.USER_ID, "", 16).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>3.lük</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");

                    sb.Append("</div>");

                    sb.Append(" <h5 class=\"panel-title\" style=\"text-align: center; font-size: 16px; color: White; margin-bottom: 10px; margin-top: 30px;\">En Karlı Satan Personel  </h5>");

                    sb.Append("<div class=\"col-lg-12 col-md-12 col-xs-12\" style=\" border: 5px solid #92a7bd; padding-top: 15px; -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7); box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);    margin-bottom: 30px;\">");

                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/goldrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount(CurrentUser.USER_ID, "", 17).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>1.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/silverrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount(CurrentUser.USER_ID, "", 18).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>2.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/bronzerosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount(CurrentUser.USER_ID, "", 19).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>3.lük</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");

                    sb.Append("</div>");
                }
                else
                {
                    sb.Append(" <h5 class=\"panel-title\" style=\"text-align: center; font-size: 16px; color: White; margin-bottom: 10px; margin-top: 30px;\">En Çok Satan Mağaza (Hedef Bazında)</h5>");
                    sb.Append("<div class=\"col-lg-12 col-md-12 col-xs-12\" style=\" border: 5px solid #92a7bd; padding-top: 15px;  -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7); box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);   margin-bottom: 30px;\">");

                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/goldrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 1).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>1.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/silverrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 2).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>2.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/bronzerosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 3).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>3.lük</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");

                    sb.Append("</div>");
                    sb.Append(" <h5 class=\"panel-title\" style=\"text-align: center; font-size: 16px; color: White; margin-bottom: 10px; margin-top: 30px;\">En Karlı Satan Mağaza </h5>");

                    sb.Append("<div class=\"col-lg-12 col-md-12 col-xs-12\" style=\" border: 5px solid #92a7bd; padding-top: 15px; -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7); box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);    margin-bottom: 30px;\">");

                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/goldrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 4).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>1.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/silverrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 5).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>2.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/bronzerosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 6).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>3.lük</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");

                    sb.Append("</div>");

                    sb.Append(" <h5 class=\"panel-title\" style=\"text-align: center; font-size: 16px; color: White; margin-bottom: 10px; margin-top: 30px;\">En Karlı Pırlanta Satan Mağaza </h5>");

                    sb.Append("<div class=\"col-lg-12 col-md-12 col-xs-12\" style=\" border: 5px solid #92a7bd; padding-top: 15px;  -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7); box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);   margin-bottom: 30px;\">");

                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/goldrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 7).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>1.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/silverrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 8).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>2.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/bronzerosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 9).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>3.lük</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");

                    sb.Append("</div>");

                    sb.Append(" <h5 class=\"panel-title\" style=\"text-align: center; font-size: 16px; color: White; margin-bottom: 10px; margin-top: 30px;\">En Karlı Altın Satan Mağaza </h5>");

                    sb.Append("<div class=\"col-lg-12 col-md-12 col-xs-12\" style=\" border: 5px solid #92a7bd; padding-top: 15px;  -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7); box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);   margin-bottom: 30px;\">");

                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/goldrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 10).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>1.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/silverrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 11).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>2.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/bronzerosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO, 12).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\"  style='font-family: fantasy;font-size: 15px;'>3.lük</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");

                    sb.Append("</div>");

                    sb.Append(" <h5 class=\"panel-title\" style=\"text-align: center; font-size: 16px; color: White; margin-bottom: 10px; margin-top: 30px;\">Mağaza Denetim Ödülü </h5>");

                    sb.Append("<div class=\"col-lg-12 col-md-12 col-xs-12\" style=\" border: 5px solid #92a7bd; padding-top: 15px; -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7); box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);    margin-bottom: 30px;\">");

                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("<div class=\"card\">");
                    sb.Append("<div class=\"thumbnail\">");
                    sb.Append("<div class=\"thumb thumb-rounded\" style=\"width: 60%\">");
                    sb.Append("<img src=\"images/goldrosette.png\">");
                    sb.Append("<span class=\"badge media-badge bg-warning-400\">" + Lizay.dll.method.USER_BADGE.Get_BadgeCount("", CurrentUser.COMPANY_NO,  13).ToString() + "</span>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"caption text-center\">");
                    sb.Append("<small class=\"display-block\" style='font-family: fantasy;font-size: 15px;'>1.lik</small>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("</div>");
                    sb.Append("<div class=\"col-lg-3 col-md-6 col-xs-4\">");
                    sb.Append("</div>");

                    sb.Append("</div>");
                
                }

                ltrozetler.Text = sb.ToString();
                
            }
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}