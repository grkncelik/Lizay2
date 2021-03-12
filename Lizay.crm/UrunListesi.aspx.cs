using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lizay.crm
{
    public partial class UrunListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentUser.USERNAME))
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            else
            {
                if (!IsPostBack)
                {
                    List<dll.entity.PRODUCT> urunler;

                    urunler = Lizay.dll.method.PRODUCT.Get_ProductList("");

                    listView.DataSource = urunler;
                    listView.DataBind();
                }

                if (Request.QueryString["SId"] != null)
                {
                    Lizay.dll.method.PRODUCT.Delete(Convert.ToInt32(Request.QueryString["SId"].ToString()));
                    Response.Redirect("UrunListesi.aspx");
                }
            }
        }



        public static string GetCategoryName(string Id)
        {
            string Name = "";

            switch (Id)
            {
                case "1": Name = "Pırlanta Yüzük"; break;
                case "2": Name = "Altın Yüzük"; break;
                case "3": Name = "Pırlanta Kolye"; break;
                case "4": Name = "Altın Kolye"; break;
                case "5": Name = "Pırlanta Küpe"; break;
                case "6": Name = "Altın Küpe"; break;
                case "7": Name = "Pırlanta Bileklik"; break;
                case "8": Name = "Altın Bileklik"; break;
                case "9": Name = "Pırlanta Setler"; break;
                case "10": Name = "Altın Setler"; break;

                default: Name = ""; break;
            }


            return Name;
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}