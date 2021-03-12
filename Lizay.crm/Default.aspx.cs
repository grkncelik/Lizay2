using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class Default : System.Web.UI.Page
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
                    List<dll.entity.ANNOUNCEMENT> duyurular;

                    duyurular = Lizay.dll.method.ANNOUNCEMENT.Get_Announcements("TUMU");

                    listView.DataSource = duyurular;
                    listView.DataBind();

                    ltrcount1.Text = duyurular.Count.ToString();


                    List<dll.entity.ANNOUNCEMENT> duyurularozel;

                    duyurularozel = Lizay.dll.method.ANNOUNCEMENT.Get_Announcements(CurrentUser.COMPANY_NO);

                    listView2.DataSource = duyurularozel;
                    listView2.DataBind();

                    ltrcount2.Text = duyurularozel.Count.ToString();


                    List<dll.entity.SLIDER> banner;

                    banner = Lizay.dll.method.SLIDER.Get_SlideBanners();

                    listViewbanner.DataSource = banner;
                    listViewbanner.DataBind();
                }
            }
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}