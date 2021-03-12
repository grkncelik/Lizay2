using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class SifreDegistir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentUser.USERNAME))
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                ClearMessageBox();

                string Password = txtPassword.Value.Trim();
                string RePassword =txtRePassword.Value.Trim();

                if (Password == "" || RePassword == "")
                {
                    ShowWarningBox("Yeni şifre giriniz");
                }
                else if (Password != RePassword)
                {
                    ShowWarningBox("Yeni şifreniz eşleşmiyor! Lütfen kontrol ediniz.");
                }
                else if (Password == "123")
                {
                    ShowWarningBox("Lütfen '123' olmayan farklı bir şifre giriniz!");
                }
                else
                {
                    Lizay.dll.method.USERS.Change_Password(CurrentUser.USERNAME, RePassword);
                    CurrentUser = new Lizay.dll.entity.USERS()
                    {
                        ISACTIVE = CurrentUser.ISACTIVE,
                        FULLNAME = CurrentUser.FULLNAME,
                        USER_TYPE = CurrentUser.USER_TYPE,
                        USERNAME = CurrentUser.USERNAME,
                        PASSWORD = RePassword
                    };

                    txtPassword.Value = "";
                    txtRePassword.Value = "";
                    ShowInfoBox("Şifreniz başarıyla değiştirilmiştir.");
                }
            }
            catch (Exception ex)
            {
                ShowWarningBox(ex.Message);
            }
        }


        public void ClearMessageBox()
        {
            ltWarningBox.Text = "";
            MessageBox.Visible = false;
            ltWarningBox2.Text = "";
            MessageBox2.Visible = false;
        }

        public void ShowWarningBox(string Message)
        {

            ltWarningBox.Text = Message;
            MessageBox.Visible = true;
        }

        public void ShowInfoBox(string Message)
        {

            ltWarningBox2.Text = Message;
            MessageBox2.Visible = true;
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new Lizay.dll.entity.USERS(); }
            set { Session["USERS"] = value; }
        }
    }
}