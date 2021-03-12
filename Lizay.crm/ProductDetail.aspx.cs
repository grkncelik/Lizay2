using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lizay.crm
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    dll.entity.PRODUCT urundetay = Lizay.dll.method.PRODUCT.Get_ProductByDetail(Convert.ToInt32(Request.QueryString["Id"].ToString()));

                    ltrTitle.Text = urundetay.NAME;
                    ltrCategory.Text = GetCategoryName(urundetay.CATEGORY_ID.ToString());
                    ltrDetail.Text = urundetay.DETAIL;
                    ltrDiscount.Text = urundetay.DISCOUNT;
                    ltrPrice.Text = urundetay.PRICE;
                    ltrProductCode.Text = urundetay.CODE;
                    ltrImg.Text = "<li><a class=\"fullscreen-icon swipebox\" href='" + urundetay.IMG + "' title='" + urundetay.NAME + "'><i class=\"fa fa-expand\"></i></a>" +
                                  "<img src='" + urundetay.IMG + "' alt='" + urundetay.NAME + "' /></li> ";
                    ltrThumb.Text = "<li> <img src='" + urundetay.IMG + "' alt=\"img\" /></li> ";

                    

                    //ltrUrl.Text = "<a class=\"btn green btn-block margin-bottom_low\" href='" + urundetay.URL + "'>Hemen Satın Al </a>";

                    ltrBack.Text = "<a href='CategoryList.aspx?Id=" + urundetay.CATEGORY_ID.ToString()+ "'><i class=\"fa fa-arrow-left\"></i></a>";

                    List<dll.entity.PRODUCT> urunler;

                    urunler = Lizay.dll.method.PRODUCT.Get_ProductList(urundetay.CATEGORY_ID.ToString());

                    listView.DataSource = urunler.Take(4);
                    listView.DataBind();
                }




            }
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Session["ProductId"] = Request.QueryString["Id"].ToString();
            Session["CategoryName"] = ltrCategory.Text;
            Session["ProductName"] = ltrTitle.Text;
            Session["ProductPrice"] = ltrDiscount.Text;
            Session["ProductCode"] = ltrProductCode.Text;
            Session["ProductImg"] = ltrThumb.Text.Replace("<li>", "").Replace("</li>","");
            Response.Redirect("Order.aspx");
        }

            public static string GetCategoryName(string Id)
        {
            string Name = "";
            Name = Lizay.dll.method.CATEGORY.Get_CategoryByDetail(Convert.ToInt32(Id)).NAME;
            return Name;
        }
    }
}