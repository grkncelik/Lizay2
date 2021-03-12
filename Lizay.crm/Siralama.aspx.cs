using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class Siralama : System.Web.UI.Page
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
                List<dll.entity.MOBILEXPENSELIST> magazasatis;

                magazasatis = Lizay.dll.method.MOBILEXPENSELIST.Get_ListSalesCompany("MAĞAZA");

                listView.DataSource = magazasatis;
                listView.DataBind();


                //List<dll.entity.MOBILEXPENSELIST> personelsatis;

                //personelsatis = Lizay.dll.method.MOBILEXPENSELIST.Get_ListSalesPerson("PERSONEL");

                //listView2.DataSource = personelsatis;
                //listView2.DataBind();
            }
        }

        public string GetCompanyName(string busarea)
        {

            return Lizay.dll.method.COMPANY.Get_CompanyByDetail(busarea).COMPANY_NAME;
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}