using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lizay.crm
{
    public partial class StoreDetail : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<dll.entity.CATEGORY> yuzuk;

                yuzuk = Lizay.dll.method.CATEGORY.Get_CategoryList("Yüzük");

                rptyuzuk.DataSource = yuzuk;
                rptyuzuk.DataBind();

                List<dll.entity.CATEGORY> kolye;

                kolye = Lizay.dll.method.CATEGORY.Get_CategoryList("Kolye");

                rptkolye.DataSource = kolye;
                rptkolye.DataBind();


                List<dll.entity.CATEGORY> kupe;

                kupe = Lizay.dll.method.CATEGORY.Get_CategoryList("Küpe");

                rptkupe.DataSource = kupe;
                rptkupe.DataBind();

                List<dll.entity.CATEGORY> bileklik;

                bileklik = Lizay.dll.method.CATEGORY.Get_CategoryList("Bileklik");

                rptbileklik.DataSource = bileklik;
                rptbileklik.DataBind();


                List<dll.entity.STORE> magaza;

                magaza = Lizay.dll.method.STORE.Get_StoreList("");

                rptmagaza.DataSource = magaza;
                rptmagaza.DataBind();


                if (Request.QueryString["Id"] != null)
                {
                    dll.entity.STORE urundetay = Lizay.dll.method.STORE.Get_StoreByDetail(Convert.ToInt32(Request.QueryString["Id"].ToString()));

                    ltrName.Text = urundetay.NAME;
                    ltrAdres.Text = urundetay.ADDRESS;
                    ltrPhone.Text = urundetay.PHONE;
                    ltrHour.Text = urundetay.WORKHOUR;
                    ltrCity.Text = urundetay.CITY;
                    ltrMap.Text = "<iframe src='" + urundetay.MAP + "' width=\"100%\" height=\"450\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>";

                }

            }
        }
    }
}