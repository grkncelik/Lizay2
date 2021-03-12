using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class RozetSiralama : System.Web.UI.Page
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
                List<dll.entity.MOBILEXPENSELIST> encoksatanmagaza;

                encoksatanmagaza = Lizay.dll.method.MOBILEXPENSELIST.Get_EnCokSatanMagaza();

                listView.DataSource = encoksatanmagaza;
                listView.DataBind();

                List<dll.entity.MOBILEXPENSELIST> enkarlisatanmagaza;

                enkarlisatanmagaza = Lizay.dll.method.MOBILEXPENSELIST.Get_EnKarliSatanMagaza();

                listView2.DataSource = enkarlisatanmagaza;
                listView2.DataBind();


                List<dll.entity.MOBILEXPENSELIST> enbasarilipirlantasatanmagaza;

                enbasarilipirlantasatanmagaza = Lizay.dll.method.MOBILEXPENSELIST.Get_EnBasariliPirlantaSatanMagaza();

                listView3.DataSource = enbasarilipirlantasatanmagaza;
                listView3.DataBind();


                List<dll.entity.MOBILEXPENSELIST> enbasarilialtinsatanmagaza;

                enbasarilialtinsatanmagaza = Lizay.dll.method.MOBILEXPENSELIST.Get_EnBasariliAltinSatanMagaza();

                listView4.DataSource = enbasarilialtinsatanmagaza;
                listView4.DataBind();



                List<dll.entity.MOBILEXPENSELIST> encoksatanpersonel;

                encoksatanpersonel = Lizay.dll.method.MOBILEXPENSELIST.Get_EnCokSatanPersonel();

                Repeater1.DataSource = encoksatanpersonel;
                Repeater1.DataBind();


                List<dll.entity.MOBILEXPENSELIST> enkarlisatanpersonel;

                enkarlisatanpersonel = Lizay.dll.method.MOBILEXPENSELIST.Get_EnKarliSatanPersonel();

                Repeater2.DataSource = enkarlisatanpersonel;
                Repeater2.DataBind();

            
            }
        }

        public string GetCompanyName(string busarea)
        {

            return Lizay.dll.method.COMPANY.Get_CompanyByDetail(busarea).COMPANY_NAME;
        }

        public static string getrosette(int row)
        {
            string res = "";

            if (row==1)
            {
                res = " <img src='images/goldrosette.png' class='img-circle' >";
            }
            if (row == 2)
            {
                res = "<img src='images/silverrosette.png' class='img-circle' >";
            }
            if (row == 3)
            {
                res = "<img src='images/bronzerosette.png' class='img-circle' >";
            }
            return res;
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}