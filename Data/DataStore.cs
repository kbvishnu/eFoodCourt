using E_FoodCourt.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_FoodCourt.Data
{
    public static class DataStore
    {

        public static UserLocation GetUserLocationDtl(int locationId)
        {
            return GetUserLocation(0).Single(loc => loc.UserLocationId == locationId);
        }

        public static List<UserLocation>  GetUserLocation(int userID)
        {
            List<UserLocation> restList = new List<UserLocation>();
            var res = new UserLocation()
            {
                UserLocationId = 2,
                AddressLine1 = "KME-122",
                AddressLine2 = "Ring Centre road",
                AddressLine3 = "R K Puram",
                City = "Kochi",
                ContactNumber = "7485966612",

                State = "Kerala",
                PinCode = "458585",
                UserId = Convert.ToInt32(SessionManager.CurrentUserId),
                LocationName = "Home",
                
            };
            restList.Add(res);
            res = new UserLocation()
            {
                UserLocationId = 3,
                AddressLine1 = "ETR-13",
                AddressLine2 = "J M Road",
                AddressLine3 = "E & C Towers",
                City = "Kochi",
                ContactNumber = "7485966612",

                State = "Kerala",
                PinCode = "458585",
                UserId = Convert.ToInt32(SessionManager.CurrentUserId),
                LocationName = "Work"
            };
            restList.Add(res);
            return restList;
        }

        internal static object GetResturantLocation(object itemId)
        {
            throw new NotImplementedException();
        }

        internal static List<ResturantTable> GetTables(int resturantLocId)
        {
            List<ResturantTable> resTables = new List<Data.ResturantTable>();
            resTables.Add(new ResturantTable() { TableCode = "TCR-1", SeatsAvailable = 4, TableReadyToUse = true });
            resTables.Add(new ResturantTable() { TableCode = "TCR-2", SeatsAvailable = 4, TableReadyToUse = true });
            resTables.Add(new ResturantTable() { TableCode = "TCR-3", SeatsAvailable = 4, TableReadyToUse = true });
            resTables.Add(new ResturantTable() { TableCode = "TCR-4", SeatsAvailable = 4, TableReadyToUse = true });
            return resTables;
        }

        public static List<Data.MenuItem> GetMenuItems(int menuId)
        {
            List<Data.MenuItem> menuList = new List<Data.MenuItem>();
            var item = new Data.MenuItem()
            {
                Cost = 40,
                Cuisine = new Data.Cuisine() { CusineName = "Mughal" },
                FoodCategory = new Data.FoodCategory() { FoodCategoryName = "Bread" },
                PreparationTime = 5,
                ItemName = "Butter Naan",
                VEG = true,
                MenuItemId = 1,
              };
            menuList.Add(item);
            item = new Data.MenuItem()
            {
                Cost = 240,
                Cuisine = new Data.Cuisine() { CusineName = "Mughal" },
                FoodCategory = new Data.FoodCategory() { FoodCategoryName = "Main Dish" },
                PreparationTime = 10,
                ItemName = "Butter Chicken Curry",
                VEG = false,
                MenuItemId = 2
            };
            menuList.Add(item);
            item = new Data.MenuItem()
            {
                Cost = 100,
                Cuisine = new Data.Cuisine() { CusineName = "Arabian" },
                FoodCategory = new Data.FoodCategory() { FoodCategoryName = "Snack" },
                PreparationTime = 1,
                ItemName = "Shawarma Roll (Chicken)",
                VEG = false,
                MenuItemId = 3
            };
            menuList.Add(item);
            item = new Data.MenuItem()
            {
                Cost = 200,
                Cuisine = new Data.Cuisine() { CusineName = "North Kerala" },
                FoodCategory = new Data.FoodCategory() { FoodCategoryName = "Rice" },
                PreparationTime = 120,
                ItemName = "Malabar Dum Biriani",
                VEG = false,
                MenuItemId = 4
            };
            menuList.Add(item);
            item = new Data.MenuItem()
            {
                Cost = 150,
                Cuisine = new Data.Cuisine() { CusineName = "South Kerala" },
                FoodCategory = new Data.FoodCategory() { FoodCategoryName = "Main Dish" },
                PreparationTime = 5,
                ItemName = "Chicken Pepper Fry",
                VEG = false,
                MenuItemId = 5
            };
            menuList.Add(item);
            item = new Data.MenuItem()
            {
                Cost = 80,
                Cuisine = new Data.Cuisine() { CusineName = "North India" },
                FoodCategory = new Data.FoodCategory() { FoodCategoryName = "Beverages" },
                PreparationTime = 3,
                ItemName = "Sweet lassi",
                VEG = true,
                MenuItemId = 6
            };
            menuList.Add(item);
            item = new Data.MenuItem()
            {
                Cost = 240,
                Cuisine = new Data.Cuisine() { CusineName = "Mughal Chicken Khema" },
                FoodCategory = new Data.FoodCategory() { FoodCategoryName = "Main Dish" },
                PreparationTime = 10,
                ItemName = "Chicken Khema",
                VEG = false,
                MenuItemId = 7
            };
            menuList.Add(item);
            item = new Data.MenuItem()
            {
                Cost = 60,
                Cuisine = new Data.Cuisine() { CusineName = "North Indian" },
                FoodCategory = new Data.FoodCategory() { FoodCategoryName = "Bread" },
                PreparationTime = 5,
                ItemName = "Aloo Paratta",
                VEG = true,
                MenuItemId = 8
            };
            menuList.Add(item);
            item = new Data.MenuItem()
            {
                Cost = 60,
                Cuisine = new Data.Cuisine() { CusineName = "South Indian" },
                FoodCategory = new Data.FoodCategory() { FoodCategoryName = "Bread" },
                PreparationTime = 5,
                ItemName = "Masala Dosa",
                VEG = true,
                MenuItemId = 9
            };
            menuList.Add(item);
            return menuList;
        }

        internal static void Search(string text)
        {
             
        }

        public static  Data.MenuItem  GetMenuItem(int menuItemId)
        {
            return GetMenuItems(0).Single(item => item.MenuItemId == menuItemId);
        }

        public static List<Data.Menu> GetMenus(int resturantId)
        {
            List<Data.Menu> menu = new List<Data.Menu>();
            menu.Add(new Data.Menu()
            {
                MenuID = 1,
                RestaurantID = 1,
                RestaurantLocationId = 1,
                MenuName = "Mix Menu",
                RestaurantLocation = new Data.RestaurantLocation()
                {
                    RestaurantLocationId = 1,
                    LocationName = "POST Office branch"
                }
            });
            return menu;
        }
    }
}