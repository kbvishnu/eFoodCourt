using E_FoodCourt.Data;
using E_FoodCourt.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace E_FoodCourt.User
{
    public partial class OrderList : System.Web.UI.Page
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
            grdViewAddress.DataSource = GetOrders(1);
            grdViewAddress.DataBind();
        }

        public class UserOrder
        {
            public string OrderId;
            public string Date;
            public string Status;
            public string Type;
            public string Amount;
            public string Review;
        }
        private List<UserOrder> GetOrders(int userID)
        {
            var orderList = new List<UserOrder>();
            orderList.Add(new UserOrder() { Amount = "250",Type="HomeDelivery", Date = "10/12/2020", Status = "Completed", OrderId = "15", Review = "" });
            orderList.Add(new UserOrder() { Amount = "280",Type="TakeAway", Date = "15/12/2020", Status = "Completed", OrderId = "17", Review = "" });
            orderList.Add(new UserOrder() { Amount = "50",Type="TakeAway", Date = "18/12/2020", Status = "Completed", OrderId = "18", Review = "" });
            orderList.Add(new UserOrder() { Amount = "850",Type="TakeAway", Date = "24/12/2020", Status = "Completed", OrderId = "19", Review = "" });
            return orderList;
            //return DataStore.GetOrders(SessionManager.CurrentUserId ?? 0);
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
                    spanAddName.InnerHtml = String.Format("<a href='../User/OrderDetails.aspx?orderId={0}'>{1}</a>",
                          loc.UserLocationId, loc.LocationName);
                    HtmlGenericControl spnAddLines = (HtmlGenericControl)e.Item.FindControl("spnAddLines");
                    spnAddLines.InnerHtml = String.Format("{0} ,{1} ,{2}", loc.AddressLine1, loc.AddressLine2, loc.AddressLine3);
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