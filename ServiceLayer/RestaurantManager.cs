using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    class RestaurantManager
    {
        private static RestaurantsContext clientContext;
        public RestaurantManager(RestaurantDbContext dbContext)
        {
            restaurantContext = new RestaurantsContext(dbContext);
        }

        public static void Create(Restaurant restaurant)
        {
            try
            {
                restaurantContext.Create(restaurant);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Restaurant Read(int key)
        {
            try
            {
                return restaurantContext.Read(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ICollection<Restaurant> ReadAll()
        {
            try
            {
                return restaurantContext.ReadAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Update(Restaurant item)
        {
            try
            {
                restaurantContext.Update(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Delete(int key)
        {
            try
            {
                restaurantContext.Delete(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
