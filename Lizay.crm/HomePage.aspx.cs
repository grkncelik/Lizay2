using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lizay.crm
{
    public partial class HomePage : System.Web.UI.Page
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


                List<dll.entity.PRODUCT> urunler;

                urunler = Lizay.dll.method.PRODUCT.Get_ProductList("");

                var listurunler = urunler.OrderBy(c => c.ID).Take(24);

                listurunler= listurunler.OrderBy(a=> Guid.NewGuid());

                listView.DataSource = listurunler;
                listView.DataBind();

                List<dll.entity.SLIDER> banner;

                banner = Lizay.dll.method.SLIDER.Get_SlideBanners();

                listViewslider.DataSource = banner;
                listViewslider.DataBind();
            }
        }

        public static string GetCategoryName(string Id)
        {
            string Name = "";
            Name = Lizay.dll.method.CATEGORY.Get_CategoryByDetail(Convert.ToInt32(Id)).NAME;
            return Name;
        }
    }
}