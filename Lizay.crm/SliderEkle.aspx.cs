using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Lizay.crm
{
    public partial class SliderEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CurrentUser.USERNAME == "")
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ClearMessageBox();

                string imgpath = "";

                if (FileUpload1.HasFile)
                {
                    imgpath="/ImageFiles/" + FileUpload1.FileName.ToString();
                    FileUpload1.SaveAs(Server.MapPath("/ImageFiles/") + FileUpload1.FileName.ToString());
                }

                Lizay.dll.method.SLIDER.Add(new dll.entity.SLIDER()
                {
                    IMG = imgpath,
                    ISACTIVE = true,
                    CREATED_DATE = DateTime.Now,

                });


                ShowInfoBox("Slider bilgileri başarıyla eklendi.");

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