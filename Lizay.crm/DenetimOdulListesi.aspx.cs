using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class DenetimOdulListesi : System.Web.UI.Page
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
                    List<dll.entity.USER_BADGE> oduller;

                    oduller = Lizay.dll.method.USER_BADGE.Get_OdulList();

                    listView.DataSource = oduller;
                    listView.DataBind();
                }

                if (Request.QueryString["SId"] != null)
                {
                    Lizay.dll.method.USER_BADGE.DeleteOdul(Convert.ToInt32(Request.QueryString["SId"].ToString()));
                    Response.Redirect("DenetimOdulListesi.aspx");
                }
            }
        }

        public static string GetCompanyName(string Id)
        {
            string Name = "";

            Name = Lizay.dll.method.COMPANY.Get_CompanyByDetail(Id.ToString()).COMPANY_NAME;

            return Name;
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}