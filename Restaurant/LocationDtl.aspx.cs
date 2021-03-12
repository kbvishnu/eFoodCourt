using E_FoodCourt.Data;
using E_FoodCourt.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_FoodCourt.Restaurant
{
    public partial class LocationDtl : System.Web.UI.Page
    {
         
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            if (Request.QueryString["addressId"] != null)
            {
                FillAddress(GetAddress(Convert.ToInt32(Request.QueryString["addressId"])));
            }
        }

        private RestaurantLocation GetAddress(int addressId)
        {
            SessionManager.CurrentUserId = 1;
            DataStore.GetMenuItems(addressId);
            return new Data.RestaurantLocation();
        }

        private void FillAddress(RestaurantLocation resLoc)
        {
            txtAddressName.Text = resLoc.LocationName;
            txtAddressLine1.Text = resLoc.AddressLine1;
            txtAddressLine2.Text = resLoc.AddressLine2;
            txtAddressLine3.Text = resLoc.AddressLine3;
            txtCity.Text = resLoc.City;
            txtPinCode.Text = resLoc.PinCode;
            ddlState.SelectedValue = resLoc.State;
        }
    }
}