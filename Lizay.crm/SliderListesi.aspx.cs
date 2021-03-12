using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class SliderListesi : System.Web.UI.Page
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
                    List<dll.entity.SLIDER> banner;

                    banner = Lizay.dll.method.SLIDER.Get_SlideBanners();

                    listView.DataSource = banner;
                    listView.DataBind();
                }

                if (Request.QueryString["SId"] != null)
                {
                    Lizay.dll.method.SLIDER.Delete(Convert.ToInt32(Request.QueryString["SId"].ToString()));
                    Response.Redirect("SliderListesi.aspx");
                }
            }
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}