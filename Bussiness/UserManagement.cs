using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using E_FoodCourt.Data;
using System.Data.Entity.Core.Objects;

namespace E_FoodCourt.Data
{
    public class UserManagement
    {
        E_FoodCourtEntities_CS userContext;
        public UserManagement()
        {
            userContext = new E_FoodCourtEntities_CS();
        }

        public bool ValidateUserCredentials(string email, string password)
        {
            ObjectResult queryResult = userContext.usp_AuthenticateUser(email, password);
            List<Nullable<int>> response = new List<Nullable<int>>();
            foreach (Nullable<int> result in queryResult)
                response.Add(result);
            return response != null && response[0].HasValue && response[0].Value == 1;
        }

        public bool RegisterUser(RegisteredUser User)
        {
            try
            {
                userContext.usp_RegisterUser(User.FirstName, User.LastName, User.MobileNumber,
                    User.CompanyName, User.EmailID, User.Active, User.Password,User.DOB);
                return true; 
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public bool SaveLocation(UserLocation loc)
        {
            try
            {
                userContext.UserLocations.Add(loc);
                userContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
  
    }
}