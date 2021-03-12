using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lizay.crm
{
    public partial class UrunEkle : System.Web.UI.Page
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

                    LoadKategori();

                }
            }
        }

        void LoadKategori()
        {
            try
            {
                ClearMessageBox();
                dropKategori.Items.Clear();
                dropKategori.Items.Add(new ListItem() { Value = "", Text = "Seçiniz" });


                dropKategori.Items.Add(new ListItem() { Value = "1", Text = "Pırlanta Yüzük" });
                dropKategori.Items.Add(new ListItem() { Value = "2", Text = "Altın Yüzük" });
                dropKategori.Items.Add(new ListItem() { Value = "3", Text = "Pırlanta Kolye" });
                dropKategori.Items.Add(new ListItem() { Value = "4", Text = "Altın Kolye" });
                dropKategori.Items.Add(new ListItem() { Value = "5", Text = "Pırlanta Küpe" });
                dropKategori.Items.Add(new ListItem() { Value = "6", Text = "Altın Küpe" });
                dropKategori.Items.Add(new ListItem() { Value = "7", Text = "Pırlanta Bileklik" });
                dropKategori.Items.Add(new ListItem() { Value = "8", Text = "Altın Bileklik" });
                dropKategori.Items.Add(new ListItem() { Value = "9", Text = "Pırlanta Setler" });
                dropKategori.Items.Add(new ListItem() { Value = "10", Text = "Altın Setler" });

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


                int CategoryId = Convert.ToInt32(dropKategori.SelectedValue);
                string Name = txtName.Value;
                string Detail = txtDetail.Value;
                string Price = txtPrice.Value;
                string Discount = txtDiscount.Value;
                string Url = txtUrl.Value;

                string imgpath = "";

                if (FileUpload1.HasFile)
                {
                    imgpath = "/ImageFiles/" + FileUpload1.FileName.ToString();
                    FileUpload1.SaveAs(Server.MapPath("/ImageFiles/") + FileUpload1.FileName.ToString());
                }


                Lizay.dll.method.PRODUCT.AddProduct(new dll.entity.PRODUCT()
                {
                    CATEGORY_ID = CategoryId,
                    NAME = Name,
                    DETAIL = Detail,
                    IMG = imgpath,
                    PRICE = Price,
                    DISCOUNT = Discount,
                    URL = Url,
   

                });


                ShowInfoBox("Ürün bilgileri başarıyla eklendi.");

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