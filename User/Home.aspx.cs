using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_FoodCourt.User
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Load();
            }
        }

        protected void grdDataGrid_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if ((e.Item.ItemType.ToString() == "Item"))
            {
                //HtmlGenericControl spnLinks1 = (HtmlGenericControl)e.Item.FindControl("spnLinks1");
                //HtmlGenericControl spnLinks2 = (HtmlGenericControl)e.Item.FindControl("spnLinks2");
                //DataRowView drv = (DataRowView)e.Item.DataItem;
                //spnLinks1.InnerHtml = String.Format("<a href='Music/Song.aspx?song_ID={0}'>{1}</a>",
                //    drv["Song_ID"], drv["Song_Title"]);
            }
        }

        private void Load()
        {
            
            BindGrid(grdDataGrid, GetFeaturedProducts());
        }

        class ProductGridDisplay
        {
            public string Category;
            public string ImageSource;
            public string Price;
            public string Name;
            public string Description;
        }

        private List<ProductGridDisplay> GetFeaturedProducts()
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add(new DataColumn() { ColumnName = "Category" });
            //dt.Columns.Add(new DataColumn() { ColumnName = "ImageSource" });
            //dt.Columns.Add(new DataColumn() { ColumnName = "Price" });
            //dt.Columns.Add(new DataColumn() { ColumnName = "Name" });
            //dt.Columns.Add(new DataColumn() { ColumnName = "Description" });
            //DataRow drow = dt.NewRow();
            //drow["Category"] = "Breakfast";
            //drow["ImageSource"] = "~/img/cook_dessert.png";
            //drow["Price"] = "20";
            //drow["Name"] = "Desrt";
            //drow["Description"] = "Testu";
            //dt.Rows.Add(drow);

            //drow = dt.NewRow();
            //drow["Category"] = "Breakfast";
            //drow["ImageSource"] = "~/img/cook_dessert.png";
            //drow["Price"] = "20";
            //drow["Name"] = "Desrt2";
            //drow["Description"] = "Testu2";
            //dt.Rows.Add(drow);

            //drow = dt.NewRow();
            //drow["Category"] = "Breakfast";
            //drow["ImageSource"] = "~/img/cook_dessert.png";
            //drow["Price"] = "20";
            //drow["Name"] = "Desrt3";
            //drow["Description"] = "Testu3";
            //dt.Rows.Add(drow);
           // List<List<ProductGridDisplay>> prodMainList = new List<List<ProductGridDisplay>>();
            List<ProductGridDisplay> prodList = new List<ProductGridDisplay>();
            ProductGridDisplay prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description= "Testu";
            prod.ImageSource= "~/img/cook_dessert.png";
            prod.Name= "Desrt";
            prod.Price= "201";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Testu2";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Desrt2";
            prod.Price = "202";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Testu3";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Desrt3";
            prod.Price = "203";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Testu3";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Desrt3";
            prod.Price = "204";
            prodList.Add(prod);

           // prodMainList.Add(prodList);
           // prodList = new List<ProductGridDisplay>();

            prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Testu3";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Desrt3";
            prod.Price = "205";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Testu3";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Desrt3";
            prod.Price = "206";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Testu3";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Desrt3";
            prod.Price = "207";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Testu3";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Desrt3";
            prod.Price = "208";
            prodList.Add(prod);


            //prodMainList.Add(prodList);
           // prodList = new List<ProductGridDisplay>();

            prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Testu3";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Desrt3";
            prod.Price = "209";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Testu3";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Desrt3";
            prod.Price = "210";
            prodList.Add(prod);


           // prodMainList.Add(prodList);
           // prodList = new List<ProductGridDisplay>();

            return prodList;
        }
        private void BindGrid(DataGrid gDataGrid, List<ProductGridDisplay> prodList)
        {
            //gDataGrid.DataSource = prodList;
            //gDataGrid.DataBind(); 
            featuredProductList.DataSource = prodList;
            featuredProductList.DataBind();
        }

        protected void featuredProductList_DataBinding(object sender, EventArgs e)
        {
           
        }

        protected void featuredProductList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            ProductGridDisplay prod = null;
            if ((e.Item.ItemType == ListViewItemType.DataItem))
            {
                prod = (ProductGridDisplay)e.Item.DataItem;
                if (prod != null)
                {
                    Label lblCategory = (Label)e.Item.FindControl("lblCategory");
                    lblCategory.Text = prod.Category;

                    Label lblPrice = (Label)e.Item.FindControl("lblPrice");
                    lblPrice.Text = prod.Price;

                    Label lblH4Content = (Label)e.Item.FindControl("lblH4Content");
                    lblH4Content.Text = prod.Name;

                    Label lblDescription = (Label)e.Item.FindControl("lblDescription");
                    lblDescription.Text = prod.Description;

                    Image Img1 = (Image)e.Item.FindControl("Img1");
                    Img1.ImageUrl = prod.ImageSource;
                }
                    
            }
        }
    }
}