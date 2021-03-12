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
    public partial class Order : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindData(Convert.ToInt32(Request.QueryString["itemId"]));
            }

         

        }

        public void BindData(int itemId)
        {
            ddlAddress.DataSource = SessionManager.UserAddress;
            ddlAddress.DataBind();

            ddlResloc.DataSource = DataStore.GetResturantLocation(itemId);
            ddlAddress.DataBind();

            Data.MenuItem item = DataStore.GetMenuItem(itemId);
            txtUnitPrice.Text = (item.Cost).ToString();
        }

        protected void btnAddtoOrder_Click(object sender, EventArgs e)
        {
            Data.MenuItem item = DataStore.GetMenuItem(Convert.ToInt32(Request.QueryString["itemId"]));
            SessionManager.OrderDtl.Add(new Data.UserOrderDetail() {
                MenuId=item.MenuItemId,UserOrder=new Data.UserOrder() { }
            } );
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../User/Home.aspx");
        }
    }
}