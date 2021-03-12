using E_FoodCourt.Data;
using E_FoodCourt.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_FoodCourt.User
{
    public partial class AddressDtl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            if(Request.QueryString["Id"]!=null)
            {
                FillAddress(GetAddress(Convert.ToInt32(Request.QueryString["Id"])));
            }
        }

        private UserLocation GetAddress(int Id)
        {
            SessionManager.CurrentUserId = 1;
            return  DataStore.GetUserLocationDtl(Id);
        }

        private void FillAddress(UserLocation userLoc)
        {
            txtAddressName.Text = userLoc.LocationName;
            txtAddressLine1.Text = userLoc.AddressLine1;
            txtAddressLine2.Text = userLoc.AddressLine2;
            txtAddressLine3.Text = userLoc.AddressLine3;
            txtCity.Text = userLoc.City;
            txtPinCode.Text = userLoc.PinCode;
            ddlState.SelectedValue = userLoc.State;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserLocation loc = new Data.UserLocation();
                loc.AddressLine1 = txtAddressLine1.Text;
                loc.AddressLine2 = txtAddressLine2.Text;
                loc.AddressLine3 = txtAddressLine3.Text;
                loc.City = txtCity.Text;
                loc.State = ddlState.SelectedValue;

            }
            catch(Exception ex)
            {

            }
        }
    }
}