using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class CanliPrim : System.Web.UI.Page
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

                //List<dll.entity.MOBILEXPENSELIST> personelprim;

                //personelprim = Lizay.dll.method.MOBILEXPENSELIST.Get_ListPuan();

                //listView2.DataSource = personelprim;
                //listView2.DataBind();
                //listView.DataSource = personelprim;
                //listView.DataBind();
            }
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}