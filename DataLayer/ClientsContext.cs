using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ClientsContext : IDb<Client, int>
    {
        private readonly RestaurantsDbContext dbContext;
        public ClientsContext(RestaurantsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Client item)
        {
            try
            {
                dbContext.Clients.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public Client Read(int key)
        {
            try
            {
                return dbContext.Clients.FirstOrDefault(x => x.Id == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ICollection<Client> ReadAll()
        {
            try
            {
                return dbContext.Clients.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Client item)
        {
            try
            {
                Client itemFromDb = Read(item.Id);
                if (itemFromDb != null)
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
        public void Delete(int key)
        {
            try
            {
                Client itemFromDb = Read(key);
                if (itemFromDb != null)
                {
                    dbContext.Clients.Remove(itemFromDb);
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
