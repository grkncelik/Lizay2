using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class Login : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["login"];

                if (cookie != null)
                {
                    string kullaniciAdi = cookie["kullaniciAdi"];
                    string sifre = cookie["sifre"];

                    MLogin(kullaniciAdi, sifre, "11111");
                }

                if (!string.IsNullOrEmpty(CurrentUser.USERNAME))
                {
                    FormsAuthentication.RedirectFromLoginPage(CurrentUser.USERNAME, false);

                }
            }
        }

        void MLogin(string kullaniciAdi, string sifre, string macaddress)
        {
            try
            {
                if (kullaniciAdi != "" && sifre != "")
                {
                    Lizay.dll.entity.USERS user = Lizay.dll.method.USERS.Get_User(kullaniciAdi, sifre);

                    if (user.USERNAME != "" && user.ISACTIVE)
                    {
                        Session["USERS"] = user;

                        var userCookie = new HttpCookie("login");
                        userCookie["kullaniciAdi"] = txtUsername.Value;
                        userCookie["sifre"] = txtPassword.Value;
                        userCookie.Expires = DateTime.Now.AddDays(100);
                        Response.Cookies.Add(userCookie);


                        if (!string.IsNullOrEmpty(DeviceId.Value))
                        {
                            if (user.DEVICE_ID != DeviceId.Value)
                            {
                                dll.method.USERS.Change_DeviceId(user.USERNAME, DeviceId.Value);
                            }
                        }


                        if (!string.IsNullOrEmpty(DeviceType.Value))
                        {
                            if (user.DEVICE_TYPE != DeviceType.Value)
                            {
                                Lizay.dll.method.USERS.Change_DeviceType(user.USERNAME, DeviceType.Value);
                            }
                        }

                        ActiveSession.ActiveUserName = user.USERNAME;

                        if (CurrentUser.USER_TYPE == "FRANCHISE")
                        {
                            Response.Redirect("urunarama.aspx");
                        }
                        else
                        {
                            Response.Redirect("Siralama.aspx");
                        }


                        // FormsAuthentication.RedirectFromLoginPage(user.USERNAME, false);

                    }
                    else
                    {
                        ShowWarningBox("Hatalı kullanıcı adı veya şifre!");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowWarningBox(ex.Message);
            }
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {

            MLogin(txtUsername.Value, txtPassword.Value, "11111");

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

            Response.Redirect("Homepage.aspx");

        }

        public void ClearMessageBox()
        {
            ltWarningBox.Text = "";
        }

        public void ShowWarningBox(string Message)
        {

            ltWarningBox.Text = "<span style='color:red;font-weight:bold;font-size:18px;'>" + Message + "</span>";
        }


        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}