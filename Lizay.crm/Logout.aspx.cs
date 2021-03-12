using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lizay.crm
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            HttpCookie userCookie = Request.Cookies["login"];
            userCookie.Expires = DateTime.Now.AddDays(-100);
            Response.Cookies.Add(userCookie);
            Response.Redirect("~/");
        }
    }
}