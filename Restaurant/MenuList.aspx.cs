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
    public partial class MenuList : System.Web.UI.Page
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

        private List<Data.Menu> GetAddress(int resturantId)
        {
            return DataStore.GetMenus(resturantId);
        }

        protected void grdViewAddress_DataBinding(object sender, EventArgs e)
        {

        }

        protected void grdViewAddress_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if ((e.Item.ItemType.ToString() == "Item") || ((e.Item.ItemType.ToString() == "AlternatingItem")))
            {
                Data.Menu item = (Data.Menu)e.Item.DataItem;
                if (item != null)
                {
                    HtmlGenericControl resLoc = (HtmlGenericControl)e.Item.FindControl("resLoc");
                    resLoc.InnerHtml = String.Format("<a href='../Restaurant/Menu.aspx?MenuID={0}'>{1}</a>",
                          item.MenuID, item.MenuName);
                    HtmlGenericControl menuName = (HtmlGenericControl)e.Item.FindControl("menuName");
                    menuName.InnerHtml = item.RestaurantLocation.LocationName;
                 }

            }
        }
    }
}