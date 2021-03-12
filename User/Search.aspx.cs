using E_FoodCourt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_FoodCourt.User
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid(GetFeaturedProducts());
        }
         

        class ProductGridDisplay
        {
            public string Category;
            public string ImageSource;
            public string Price;
            public string Name;
            public string Description;
            public string ItemId;
        }

        private List<ProductGridDisplay> GetFeaturedProducts()
        {
             
            List<ProductGridDisplay> prodList = new List<ProductGridDisplay>();
            ProductGridDisplay prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Chicken stew with idiappam";
            prod.ImageSource = "~/img/chickenstew.png";
            prod.Name = "Chicken Stew";
            prod.Price = "180";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Lunch";
            prod.Description = "Beef fried with coconut";
            prod.ImageSource = "~/img/beeffry.jpg";
            prod.Name = "Kerala Beef fry";
            prod.Price = "190";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Dinner";
            prod.Description = "Barbeque Chicken with Butter Naan";
            prod.ImageSource = "~/img/bbq.jpg";
            prod.Name = "BBQ Combo";
            prod.Price = "200";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Dinner";
            prod.Description = "Mushrooms and chilles";
            prod.ImageSource = "~/img/mushroomrice.jpg";
            prod.Name = "Mushroom Jeera Rice";
            prod.Price = "150";
            prodList.Add(prod);

            // prodMainList.Add(prodList);
            // prodList = new List<ProductGridDisplay>();

            prod = new ProductGridDisplay();
            prod.Category = "Lunch";
            prod.Description = "Kerala Non Veg Meals";
            prod.ImageSource = "~/img/keralanonvegmeals.jpg";
            prod.Name = "Meals";
            prod.Price = "170";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Snack";
            prod.Description = "Chicken Sandwitch";
            prod.ImageSource = "~/img/chickensandwitch.jpg";
            prod.Name = "Desrt3";
            prod.Price = "20";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Beverages";
            prod.Description = "Falooda with dry fruits";
            prod.ImageSource = "~/img/falooda.jpg";
            prod.Name = "Falooda";
            prod.Price = "150";
            prodList.Add(prod);

             
            prod = new ProductGridDisplay();
            prod.Category = "Dinner";
            prod.Description = "Ghee Rice with various combinations";
            prod.ImageSource = "~/img/grice.jpg";
            prod.Name = "Ghee Rice";
            prod.Price = "130";
            prodList.Add(prod);

            prod = new ProductGridDisplay();
            prod.Category = "Breakfast";
            prod.Description = "Masala Dosa and Vada";
            prod.ImageSource = "~/img/masaladosa.jpg";
            prod.Name = "Masala Dosa";
            prod.Price = "80";
            prodList.Add(prod);


            // prodMainList.Add(prodList);
            // prodList = new List<ProductGridDisplay>();

            return prodList;
        }
        private void BindGrid(List<ProductGridDisplay> prodList)
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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataStore.Search(txtSearch.Text);
            }
            catch(Exception ex)
            {

            }
        }
    }
}