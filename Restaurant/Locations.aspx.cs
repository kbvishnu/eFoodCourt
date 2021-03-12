using E_FoodCourt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace E_FoodCourt.Restaurant
{
    public partial class Locations : System.Web.UI.Page
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
            int resturantId = Convert.ToInt32(Request.QueryString["resturantId"]);
            grdViewAddress.DataSource = GetAddress(1);
            grdViewAddress.DataBind();
        }

        private List<RestaurantLocation> GetAddress(int restaurantId)
        {
            List<RestaurantLocation> restList = new List<RestaurantLocation>();
            var res = new RestaurantLocation()
            {
                RestaurantLocationId = 1,
                AddressLine1 = "2/20 PBT Towers",
                AddressLine2 = "Old Passport Office Road",
                AddressLine3 = "R K Puram",
                City = "Kochi",
                ContactNumber1 = "74859121212",
                ContactNumber2 = "74859121213",
                State = "Kerala",
                PinCode = "458580"
            };
            restList.Add(res);
            res = new RestaurantLocation()
            {
                RestaurantLocationId = 3,
                AddressLine1 = "D/12",
                AddressLine2 = "D H Towers",
                AddressLine3 = "Idappally",
                City = "Kochi",
                ContactNumber1 = "7485960012",
                ContactNumber2 = "7485960002",
                State = "Kerala",
                PinCode = "458585", 
            };
            restList.Add(res);
            return restList;
        }

        protected void grdViewAddress_DataBinding(object sender, EventArgs e)
        {

        }

        protected void grdViewAddress_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if ((e.Item.ItemType.ToString() == "Item") || ((e.Item.ItemType.ToString() == "AlternatingItem")))
            {
                RestaurantLocation loc = (RestaurantLocation)e.Item.DataItem;
                if (loc != null)
                {

                    HtmlGenericControl spanAddName = (HtmlGenericControl)e.Item.FindControl("spanAddName");
                    spanAddName.InnerHtml = String.Format("<a href='../Restaurant/LocationDtl.aspx?ID={0}'>{0}</a>",
                          loc.RestaurantLocationId);
                    HtmlGenericControl spnAddLines = (HtmlGenericControl)e.Item.FindControl("spnAddLines");
                    spnAddLines.InnerHtml = String.Format("{0} ,{1} ,{2}", loc.AddressLine1, loc.AddressLine2, loc.AddressLine3);
                    HtmlGenericControl spnPinCode = (HtmlGenericControl)e.Item.FindControl("spnPinCode");
                    spnPinCode.InnerHtml = loc.PinCode;
                    HtmlGenericControl spnCity = (HtmlGenericControl)e.Item.FindControl("spnCity");
                    spnCity.InnerHtml = loc.City;                    
                    HtmlGenericControl spnState = (HtmlGenericControl)e.Item.FindControl("spnState");
                    spnState.InnerHtml = loc.State;                   
                    HtmlGenericControl spnContactNumber = (HtmlGenericControl)e.Item.FindControl("spnContactNumber");
                    spnContactNumber.InnerHtml = String.Format("{0} ,{1}",loc.ContactNumber1,loc.ContactNumber2);

                    HtmlGenericControl spanTables = (HtmlGenericControl)e.Item.FindControl("spanAddTables");
                    spanTables.InnerHtml = String.Format("<a href='../Restaurant/TableReservations.aspx?ID={0}'>{0}</a>",
                          loc.RestaurantLocationId);
                    HtmlGenericControl spanFacility = (HtmlGenericControl)e.Item.FindControl("spanAddFacilities");
                    spanFacility.InnerHtml = String.Format("<a href='../Restaurant/ResturantFacility.aspx?ID={0}'>{0}</a>",
                          loc.RestaurantLocationId);

                }

            }
        }
    }
}