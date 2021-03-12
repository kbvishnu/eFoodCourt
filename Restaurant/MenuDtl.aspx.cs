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
    public partial class MenuDtl : System.Web.UI.Page
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

        private List<Data.MenuItem> GetAddress(int menuId)
        {
            return   DataStore.GetMenuItems(menuId);
        }

        protected void grdViewAddress_DataBinding(object sender, EventArgs e)
        {

        }

        protected void grdViewAddress_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if ((e.Item.ItemType.ToString() == "Item") || ((e.Item.ItemType.ToString() == "AlternatingItem")))
            {
                Data.MenuItem item = (Data.MenuItem)e.Item.DataItem;
                if (item != null)
                {

                    HtmlGenericControl spanItemName = (HtmlGenericControl)e.Item.FindControl("spanItemName");
                    spanItemName.InnerHtml = String.Format("<a href='../Restaurant/MenuItemDtl.aspx?ItemID={0}'>{0}</a>",
                          item.MenuItemId,item.ItemName);
                    HtmlGenericControl spnFoodCategory = (HtmlGenericControl)e.Item.FindControl("FoodCategory");
                    spnFoodCategory.InnerHtml = item.FoodCategory.FoodCategoryName;
                    HtmlGenericControl spnCusine = (HtmlGenericControl)e.Item.FindControl("Cusine");
                    spnCusine.InnerHtml = item.Cuisine.CusineName;
                    HtmlGenericControl spnPreparationTime = (HtmlGenericControl)e.Item.FindControl("PreparationTime");
                    spnPreparationTime.InnerHtml = item.PreparationTime.ToString();
                    HtmlGenericControl spnCost = (HtmlGenericControl)e.Item.FindControl("Cost");
                    spnCost.InnerHtml = item.Cost.ToString();
                    Image imgItem = (Image)e.Item.FindControl("imgItem");
                    imgItem.ImageUrl = item.CusineImage1;
                    CheckBox cbVeg=(CheckBox)e.Item.FindControl("cbVeg");
                    cbVeg.Checked = item.VEG;

                }

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}