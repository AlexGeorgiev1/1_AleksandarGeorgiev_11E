using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RestaurantsContext : IDb<Restaurant, string>
    {
        private readonly RestaurantsDbContext dbContext;
        public RestaurantsContext(RestaurantsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Restaurant item)
        {
            try
            {
                dbContext.Restaurants.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Restaurant Read(string key)
        {
            try
            {
                return dbContext.Restaurants.FirstOrDefault(x => x.Name == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ICollection<Restaurant> ReadAll()
        {
            try
            {
                return dbContext.Restaurants.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Restaurant item)
        {
            try
            {
                Restaurant itemFromDb = Read(item.Name);
                if(itemFromDb != null)
                {
                    dbContext.Entry(itemFromDb).CurrentValues.SetValues(item);
                }
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Delete(string key)
        {
            try
            {
                Restaurant itemFromDb = Read(key);
                if (itemFromDb != null)
                {
                    dbContext.Restaurants.Remove(itemFromDb);
                }
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
