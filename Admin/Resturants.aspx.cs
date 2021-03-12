using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace E_FoodCourt.Admin
{
    public partial class Resturants : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }

        }

        public class ResturantInfo
        {
            public string Id;
            public string Name;
            public string ImageSource;
            public bool IsActive;
            public string ContactNumber;
        }

        private void BindData()
        {
            gridViewListResturants.DataSource = GetResturants();
            gridViewListResturants.DataBind();
        }

        private List<ResturantInfo> GetResturants()
        {
            List<ResturantInfo> restList = new List<ResturantInfo>();
            var res = new ResturantInfo() { ContactNumber = "7872838881", Id = "1", ImageSource = "", IsActive = true, Name = "Shalimar" };
            restList.Add(res);
            res = new ResturantInfo() { ContactNumber = "4572838661", Id = "2", ImageSource = "", IsActive = true, Name = "Ida" };
            restList.Add(res);
            res = new ResturantInfo() { ContactNumber = "7873445899", Id = "3", ImageSource = "", IsActive = true, Name = "Annapoorna" };
            restList.Add(res);
            res = new ResturantInfo() { ContactNumber = "9875533234", Id = "4", ImageSource = "", IsActive = true, Name = "HFC" };
            restList.Add(res);
            res = new ResturantInfo() { ContactNumber = "8754468812", Id = "5", ImageSource = "", IsActive = true, Name = "Tasty" };
            restList.Add(res);


            return restList;
        }

        protected void gridViewListResturants_DataBinding(object sender, EventArgs e)
        {

        }

        protected void gridViewListResturants_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if ((e.Item.ItemType.ToString() == "Item")||((e.Item.ItemType.ToString() == "AlternatingItem")))
            {
                ResturantInfo rest = (ResturantInfo)e.Item.DataItem;
                if (rest != null)
                {

                    HtmlGenericControl spnLinks1 = (HtmlGenericControl)e.Item.FindControl("spnRes");
                    spnLinks1.InnerHtml = String.Format("<a href='../Restaurant/Restuarnt.aspx?ID={0}'>{1}</a>",
                          rest.Id, rest.Name);
                    Label lblId = (Label)e.Item.FindControl("lblId");
                    lblId.Text = rest.Id;
                    CheckBox cbActive = (CheckBox)e.Item.FindControl("cbActive");
                    cbActive.Checked = rest.IsActive;
                    Label lblContact = (Label)e.Item.FindControl("lblContact");
                    lblContact.Text = rest.ContactNumber;
                }

            }
        }
    }
}