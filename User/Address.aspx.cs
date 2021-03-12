using E_FoodCourt.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_FoodCourt.Data;
using System.Web.UI.HtmlControls;

namespace E_FoodCourt.User
{
    public partial class Address : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }

        }

      

        private void BindData()
        {
            grdViewAddress.DataSource = GetAddress(1);
            grdViewAddress.DataBind();
        }

        private List<UserLocation> GetAddress(int userID)
        {
            SessionManager.CurrentUserId = 1;
            return  DataStore.GetUserLocation(SessionManager.CurrentUserId??0);
        }

        protected void grdViewAddress_DataBinding(object sender, EventArgs e)
        {

        }

        protected void grdViewAddress_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if ((e.Item.ItemType.ToString() == "Item") || ((e.Item.ItemType.ToString() == "AlternatingItem")))
            {
                UserLocation loc = (UserLocation)e.Item.DataItem;
                if (loc != null)
                {
                    
                    HtmlGenericControl spanAddName = (HtmlGenericControl)e.Item.FindControl("spanAddName");
                    spanAddName.InnerHtml = String.Format("<a href='../AddressDetail/addressId.aspx?addressID={0}'>{1}</a>",
                          loc.UserLocationId,loc.LocationName);
                    HtmlGenericControl spnAddLines = (HtmlGenericControl)e.Item.FindControl("spnAddLines");
                    spnAddLines.InnerHtml = String.Format("{0} ,{1} ,{2}",loc.AddressLine1,loc.AddressLine2,loc.AddressLine3);
                    HtmlGenericControl spnPinCode = (HtmlGenericControl)e.Item.FindControl("spnPinCode");
                    spnPinCode.InnerHtml = loc.PinCode;
                    HtmlGenericControl spnCity = (HtmlGenericControl)e.Item.FindControl("spnCity");
                    spnCity.InnerHtml = loc.City;
                    //HtmlGenericControl spnDistrict = (HtmlGenericControl)e.Item.FindControl("spnDistrict");
                    //spnDistrict.InnerHtml = loc.District;
                    HtmlGenericControl spnState = (HtmlGenericControl)e.Item.FindControl("spnState");
                    spnState.InnerHtml = loc.State;
                    //HtmlGenericControl spnCountry = (HtmlGenericControl)e.Item.FindControl("spnCountry");
                    //spnCountry.InnerHtml = loc.Country;
                    HtmlGenericControl spnContactNumber = (HtmlGenericControl)e.Item.FindControl("spnContactNumber");
                    spnContactNumber.InnerHtml = loc.ContactNumber;
                     
                }

            }
        }
    }
}