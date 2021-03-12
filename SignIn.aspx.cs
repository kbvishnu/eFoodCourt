using E_FoodCourt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_FoodCourt.Session;

namespace E_FoodCourt
{
    public partial class SignIn : System.Web.UI.Page
    {
        UserManagement userMgr = new UserManagement();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            if(userMgr.ValidateUserCredentials(txtEmailAddress.Text, txtPassword.Text))
            {
                SessionManager.CurrentUserEmailId = txtEmailAddress.Text;
                Response.Redirect("/User/Profile.aspx");
            }
            
        }
    }
}