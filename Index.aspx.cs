using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_FoodCourt
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

            BindGrid( GetFeaturedProducts());
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
       
            List<ProductGridDisplay> prodList = new List<ProductGridDisplay>();
            ProductGridDisplay prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Authentic tamil style dosa";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Masala Dosa";
            prod.Price = "45.00";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Lunch";
            prod.Description = "Truley malabar";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Malabar Dum Biriani";
            prod.Price = "180.00";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Dinner";
            prod.Description = "Chineese noodles";
            prod.ImageSource = "~/img/cook_dessert.png";
            prod.Name = "Chicken Noodles";
            prod.Price = "180.00";
            prodList.Add(prod);

            //prod = new ProductGridDisplay();
            //prod.Category = "Breakfast";
            //prod.Description = "Testu3";
            //prod.ImageSource = "~/img/cook_dessert.png";
            //prod.Name = "Desrt3";
            //prod.Price = "204";
            //prodList.Add(prod);

            //// prodMainList.Add(prodList);
            //// prodList = new List<ProductGridDisplay>();

            //prod = new ProductGridDisplay();
            //prod.Category = "Breakfast";
            //prod.Description = "Testu3";
            //prod.ImageSource = "~/img/cook_dessert.png";
            //prod.Name = "Desrt3";
            //prod.Price = "205";
            //prodList.Add(prod);

            //prod = new ProductGridDisplay();
            //prod.Category = "Breakfast";
            //prod.Description = "Testu3";
            //prod.ImageSource = "~/img/cook_dessert.png";
            //prod.Name = "Desrt3";
            //prod.Price = "206";
            //prodList.Add(prod);

            //prod = new ProductGridDisplay();
            //prod.Category = "Breakfast";
            //prod.Description = "Testu3";
            //prod.ImageSource = "~/img/cook_dessert.png";
            //prod.Name = "Desrt3";
            //prod.Price = "207";
            //prodList.Add(prod);

            //prod = new ProductGridDisplay();
            //prod.Category = "Breakfast";
            //prod.Description = "Testu3";
            //prod.ImageSource = "~/img/cook_dessert.png";
            //prod.Name = "Desrt3";
            //prod.Price = "208";
            //prodList.Add(prod);


            ////prodMainList.Add(prodList);
            //// prodList = new List<ProductGridDisplay>();

            //prod = new ProductGridDisplay();
            //prod.Category = "Breakfast";
            //prod.Description = "Testu3";
            //prod.ImageSource = "~/img/cook_dessert.png";
            //prod.Name = "Desrt3";
            //prod.Price = "209";
            //prodList.Add(prod);

            //prod = new ProductGridDisplay();
            //prod.Category = "Breakfast";
            //prod.Description = "Testu3";
            //prod.ImageSource = "~/img/cook_dessert.png";
            //prod.Name = "Desrt3";
            //prod.Price = "210";
            //prodList.Add(prod);


            // prodMainList.Add(prodList);
            // prodList = new List<ProductGridDisplay>();

            return prodList;
        }
        private void BindGrid(List<ProductGridDisplay> prodList)
        {
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