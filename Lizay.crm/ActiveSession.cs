using System;
using System.Web;

namespace Lizay.crm
{
    public static class ActiveSession
    {

        public static string ActiveUrunFilter
        {
            get => HttpContext.Current.Session["ActiveSession_ActiveUrunFilter"] == null
                ? null
                : HttpContext.Current.Session["ActiveSession_ActiveUrunFilter"].ToString();
            set => HttpContext.Current.Session["ActiveSession_ActiveUrunFilter"] = value;
        }


        public static string ActiveUserName
        {
            get => HttpContext.Current.Session["ActiveSession_ActiveUserName"] == null
                ? null
                : HttpContext.Current.Session["ActiveSession_ActiveUserName"].ToString();
            set => HttpContext.Current.Session["ActiveSession_ActiveUserName"] = value;
        }




    }
}