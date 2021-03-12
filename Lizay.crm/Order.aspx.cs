using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lizay.crm
{
    public partial class Order : System.Web.UI.Page
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


                dropOdemeTip.Items.Add(new ListItem() { Value = "1", Text = "Kapıda Ödeme" });
                dropOdemeTip.Items.Add(new ListItem() { Value = "2", Text = "Havale" });
                dropOdemeTip.Items.Add(new ListItem() { Value = "3", Text = "Mağazadan Alacağım" });


                for (int i = 6; i < 23; i++)
                {
                    dropOlcu.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }


                foreach (var item in magaza)
                {
                    dropMagaza.Items.Add(new ListItem() { Value = item.NAME, Text = item.NAME });
                }


                txtOrderDate.Value = DateTime.Now.ToShortDateString();
                txtOrderno.Value = KodOlustur();
                txtProductName.Value = Session["ProductName"].ToString();
                txtAmount.Value = Session["ProductPrice"].ToString() + " TL";
                txtProductCode.Value = Session["ProductCode"].ToString();

                if (Session["CategoryName"].ToString().IndexOf("Yüzük")!=-1)
                {
                    divolcu.Visible = true;

                    divyazi.Visible = true;
                }


                ltrBack.Text = "<a href='ProductDetail.aspx?Id=" + Session["ProductId"].ToString() + "'><i class=\"fa fa-arrow-left\"></i></a>";
            }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropOdemeTip.SelectedValue == "3")
            {
                divmagaza.Visible = true;
            }
            else
            {
                divmagaza.Visible = false;
            }

            if (Session["CategoryName"].ToString().IndexOf("Yüzük") != -1)
            {
                divolcu.Visible = true;
                divyazi.Visible = true;
            }
        }

        public string KodOlustur()
        {
            string kod = Guid.NewGuid().ToString();
            // kod isimli degiskene Guid' in verisini aktardık

            string sonKod = string.Empty;
            // sadece ayıların ekleneceği bir değişken tanımladık.

            foreach (char item in kod)
            // char tipinde kod değişkenin içinde veri aradık
            {
                if (char.IsNumber(item))
                // char tipindeki veri sayı ise
                {
                    sonKod += item;
                    // sonKod isimli değişkene harflerden ayrılmış değerleri aktardık.
                }
            }

            sonKod = sonKod.Substring(0, 6);
            // 0' dan başlayıp 6 karakter kesmesini belirttik

            return sonKod;
            // medotun döndüreceği değeri belirttik.

        }

        protected void btnTamamla_Click(object sender, EventArgs e)
        {

            Session["Olcu"] = dropOlcu.SelectedValue;
            Session["OrderDate"] = txtOrderDate.Value;
            Session["OrderNo"] = txtOrderno.Value;
            Session["Text"] = txtText.Value;
            Session["OdemeTipi"] = dropOdemeTip.SelectedItem.Text;
            Session["SiparisNotu"] = txtOrdernote.Value;
            Response.Redirect("OrderHistory.aspx");
        }
    }
}