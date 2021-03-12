using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class Raporlama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (CurrentUser.USERNAME == "")
            {
                FormsAuthentication.RedirectToLoginPage();
            }

            if (!IsPostBack)
            {
                LoadData();
                LoadData2();

            }
        }

        void LoadData()
        {
            try
            {
                var datalar = Lizay.dll.method.CHARTLIST.Get_List("");
                rptCharts.DataSource = datalar;
                rptCharts.DataBind();
            }
            catch (Exception ex)
            { }
        }


        void LoadData2()
        {
            try
            {
                var datalar = Lizay.dll.method.CHARTLIST.Get_List2("");
                rptCharts2.DataSource = datalar;
                rptCharts2.DataBind();
            }
            catch (Exception ex)
            { }
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}