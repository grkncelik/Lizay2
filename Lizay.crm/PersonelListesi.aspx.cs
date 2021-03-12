using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Lizay.dll.entity;

namespace Lizay.crm
{
    public partial class PersonelListesi : System.Web.UI.Page
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
                    var personeller = dll.method.USERS.Get_UserList("", "", "", "", "");

                    listView.DataSource = personeller;
                    listView.DataBind();
                }

                if (Request.QueryString["SId"] != null)
                {
                    dll.method.USERS.DeleteUser(Convert.ToInt32(Request.QueryString["SId"]));
                    Response.Redirect("PersonelListesi.aspx");
                }
            }
        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = ((Button)sender).CommandArgument;
                dll.method.USERS.Change_Password(userName, "123456");
                Response.Redirect("PersonelListesi.aspx");
            }
            catch (Exception ex)
            {
            }
        }


        public static string GetCompanyName(string Id)
        {
            string Name = "";

            Name = dll.method.COMPANY.Get_CompanyByDetail(Id).COMPANY_NAME;

            return Name;
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}