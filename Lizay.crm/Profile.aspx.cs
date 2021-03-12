using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class Profile : System.Web.UI.Page
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

                    var PersonelBilgisi = Lizay.dll.method.USERS.Get_UserByDetail(CurrentUser.USERNAME);

                    ltrimg.Text = " <img src='" + PersonelBilgisi.PROFILE_PHOTO + "' class=\"img-circle\" style=\"width: 140px; height: 140px;\" />";
                    ltrname.Text = PersonelBilgisi.FULLNAME + " <small class=\"display-block\">" + PersonelBilgisi.COMPANY_NO + " - " + GetCompanyName(PersonelBilgisi.COMPANY_NO) + "</small>";
                    txtBirthday.Value = PersonelBilgisi.BIRTHDAY;
                    txtEmail.Value = PersonelBilgisi.EMAIL;
                    txtGsm.Value = PersonelBilgisi.GSMNO;

                    string puan = "0";
                    string rozet = "0";

                    if (CurrentUser.USER_TYPE=="PERSONEL")
                    {
                        rozet = dll.method.USER_BADGE.Get_TotalBadgeCount(CurrentUser.USER_ID,"").ToString();
                    }
                    if (CurrentUser.USER_TYPE == "MUDUR")
                    {
                        rozet = dll.method.USER_BADGE.Get_TotalBadgeCount("", CurrentUser.COMPANY_NO).ToString();
                    }


                    if (CurrentUser.USER_TYPE == "PERSONEL")
                    {
                        puan = dll.method.MOBILEXPENSELIST.Get_TotalPuanPersonel(CurrentUser.USER_ID).ToString();
                    }
                    if (CurrentUser.USER_TYPE == "MUDUR")
                    {
                        puan = dll.method.MOBILEXPENSELIST.Get_TotalPuanCompany(CurrentUser.COMPANY_NO).ToString();
                    }


                    ltpuan.Text = puan;
                    ltrozet.Text=rozet;



                }
            }
        }

        public static string GetCompanyName(string Id)
        {
            string Name = "";

            Name = Lizay.dll.method.COMPANY.Get_CompanyByDetail(Id.ToString()).COMPANY_NAME;

            return Name;
        }

        protected void btnGenel_Click(object sender, EventArgs e)
        {
            pnlGenel.Visible = true;
            pnlProfile.Visible = false;
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            pnlGenel.Visible = false;
            pnlProfile.Visible = true;
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ClearMessageBox();

                string Email = txtEmail.Value;
                string Gsm = txtGsm.Value;
                string Birthday = txtBirthday.Value;


                string imgpath = "";

                if (FileUpload1.HasFile)
                {
                    imgpath = "/ImageFiles/" + FileUpload1.FileName.ToString();
                    FileUpload1.SaveAs(Server.MapPath("/ImageFiles/") + FileUpload1.FileName.ToString());
                }
                else
                {
                    imgpath = CurrentUser.PROFILE_PHOTO;
                }

                Lizay.dll.method.USERS.UpdateUser(new dll.entity.USERS()
                {
                    USERNAME = CurrentUser.USERNAME,
                    EMAIL = Email,
                    GSMNO = Gsm,
                    MODIFIED_DATE = DateTime.Now,
                    MODIFIED_USER = CurrentUser.USERNAME,
                    PROFILE_PHOTO = imgpath,
                    BIRTHDAY = Birthday,

                });


                ShowInfoBox("Profil bilgileriniz başarıyla güncellendi.");

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

        public void ShowWarningBox(string Message)
        {
            MessageBox.CssClass = "WarningBox";
            ltWarningBox.Text = Message;
            MessageBox.Visible = true;
        }

        public void ShowInfoBox(string Message)
        {
            MessageBox2.CssClass = "InfoBox";
            ltWarningBox2.Text = Message;
            MessageBox2.Visible = true;
        }

        public Lizay.dll.entity.USERS CurrentUser
        {
            get { if (Session["USERS"] != null) return (Lizay.dll.entity.USERS)Session["USERS"]; return new dll.entity.USERS(); }
        }
    }
}