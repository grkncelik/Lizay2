using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Lizay.dll.entity;

namespace Lizay.crm
{
    public partial class PersonelEkle : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CurrentUser.USERNAME == "")
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            else
            {
                if (!IsPostBack)
                {
                    LoadMagaza();
                }
            }
        }

        void LoadMagaza()
        {
            try
            {
                ClearMessageBox();
                dropMagaza.Items.Clear();
                dropMagaza.Items.Add(new ListItem() { Value = "", Text = "Seçiniz" });

                var magaza = dll.method.COMPANY.Get_CompanyList("");

                foreach (var item in magaza)
                {
                    dropMagaza.Items.Add(new ListItem() { Value = item.COMPANY_NO, Text = item.COMPANY_NAME });
                }
            }
            catch (Exception ex)
            {
                ShowWarningBox(ex.Message);
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ClearMessageBox();

                if (string.IsNullOrEmpty(dropUserType.SelectedValue))
                {
                    ShowWarningBox("Kullanıcı Tipi Seçiniz!!!");
                    return;
                }

                var magaza = dropMagaza.SelectedValue;
                var username = txtUsername.Value;
                var fullname = txtFullname.Value;
                var email = txtEmail.Value;
                var gsm = txtGsm.Value;
                var password = txtPassword.Value;

                var imgpath = "";

                if (FileUpload1.HasFile)
                {
                    imgpath = "/ImageFiles/" + FileUpload1.FileName;
                    FileUpload1.SaveAs(Server.MapPath("/ImageFiles/") + FileUpload1.FileName);
                }


                Lizay.dll.method.USERS.AddNewUser(new USERS
                {
                    COMPANY_NO = magaza,
                    USERNAME = username,
                    FULLNAME = fullname,
                    EMAIL = email,
                    GSMNO = gsm,
                    DELETED = false,
                    ISACTIVE = true,
                    CREATED_DATE = DateTime.Now,
                    MODIFIED_DATE = DateTime.Now,
                    MODIFIED_USER = CurrentUser.USERNAME,
                    USER_TYPE = dropUserType.SelectedValue,
                    PASSWORD = password,
                    PROFILE_PHOTO = imgpath,
                    BIRTHDAY = ""
                });


                ShowInfoBox("Personel bilgileri başarıyla eklendi.");

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
        }

        public void ShowWarningBox(string message)
        {
            MessageBox.CssClass = "WarningBox";
            ltWarningBox.Text = message;
            MessageBox.Visible = true;
        }

        public void ShowInfoBox(string message)
        {
            MessageBox2.CssClass = "InfoBox";
            ltWarningBox2.Text = message;
            MessageBox2.Visible = true;
        }

        public USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (USERS)Session["USERS"]; return new USERS(); }
        }
    }
}