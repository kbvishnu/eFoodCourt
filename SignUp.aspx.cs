using E_FoodCourt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_FoodCourt
{
    public partial class SignUp : System.Web.UI.Page
    {
        UserManagement user = new UserManagement();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                 
                var regUser = new RegisteredUser()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtSecondName.Text,
                    EmailID = txtEmailAddress.Text,
                    Password = txtPassword.Text,
                    DOB = Convert.ToDateTime(txtDOB.Text),
                    MobileNumber=txtMobileNumber.Text,
                    Active=true
                };
                user.RegisterUser(regUser);

            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.GetBaseException().Message;
            }
        }
    }
}