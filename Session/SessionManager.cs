using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_FoodCourt.Data;

namespace E_FoodCourt.Session
{
    public class SessionManager
    {

        public static object CurrentUser
        {
            get
            {
                if (HttpContext.Current.Session["User"] != null)
                    return Convert.ToString(HttpContext.Current.Session["User"]);
                else
                    return null;
            }
            set
            {
                HttpContext.Current.Session["User"] = value;
            }
        }

        public static int? CurrentUserId
        {
            get
            {
                if (HttpContext.Current.Session["UserId"] != null)
                    return Convert.ToInt32(HttpContext.Current.Session["UserId"]);
                else
                    return null;
            }
            set
            {
                HttpContext.Current.Session["UserId"] = value;
            }
        }


        public static string CurrentUserEmailId
        {
            get
            {
                if (HttpContext.Current.Session["UserEmailID"] != null)
                    return Convert.ToString(HttpContext.Current.Session["UserEmailID"]);
                else
                    return "No User Logged In";
            }
            set
            {
                HttpContext.Current.Session["UserEmailID"] = value;
            }
        }

        public static bool IsAdmin
        {
            get
            {
                if (HttpContext.Current.Session["IsAdmin"] != null)
                    return Convert.ToBoolean(HttpContext.Current.Session["IsAdmin"]);
                else
                    return false;
            }
            set
            {
                HttpContext.Current.Session["IsAdmin"] = value;
            }
        }

        public static bool IsSessionAvailable
        {
            get
            {
                return CurrentUser != null;
            }
        }

        public static object UserAddress { get; set; }
        public static List<UserOrderDetail> OrderDtl{ get;  set; }

    public static void LogOut()
    {
        HttpContext.Current.Session.Clear();
        HttpContext.Current.Session.Abandon();
        HttpContext.Current.Response.Redirect("~/Index.aspx", true);
        HttpContext.Current.Response.End();
    }


}
}