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
    public partial class TableReservations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }

        }


        protected void grdViewAddress_CancelCommand(object source, DataGridCommandEventArgs e)
        {

        }

        protected void grdViewAddress_DeleteCommand(object source, DataGridCommandEventArgs e)
        {

        }

        protected void grdViewAddress_EditCommand(object source, DataGridCommandEventArgs e)
        {

        }
        

        private void BindData()
        {
            int resturantId = Convert.ToInt32(Request.QueryString["resturantId"]);
            grdViewAddress.DataSource = GetTables(1);
            grdViewAddress.DataBind();
        }

        private List<Data.ResturantTable> GetTables(int resturantLocId)
        {
            return DataStore.GetTables(resturantLocId);
        }

        protected void grdViewAddress_DataBinding(object sender, EventArgs e)
        {

        }

        protected void grdViewAddress_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if ((e.Item.ItemType.ToString() == "Item") || ((e.Item.ItemType.ToString() == "AlternatingItem")))
            {
                Data.ResturantTable item = (Data.ResturantTable)e.Item.DataItem;
                if (item != null)
                {

                    HtmlGenericControl spanItemName = (HtmlGenericControl)e.Item.FindControl("TableCode");
                    spanItemName.InnerHtml =  item.TableCode;
                    HtmlGenericControl spnFoodCategory = (HtmlGenericControl)e.Item.FindControl("Seats");
                    spnFoodCategory.InnerHtml = item.SeatsAvailable.ToString();
                  
                    CheckBox cbVeg = (CheckBox)e.Item.FindControl("cbReadyToUse");
                    cbVeg.Checked = item.TableReadyToUse;

                }

            }
        }

         
    }
}