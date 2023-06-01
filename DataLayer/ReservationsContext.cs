using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ReservationsContext : IDb<Reservation, int>
    {
        private readonly RestaurantsDbContext dbContext;
        public ReservationsContext(RestaurantsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Reservation item)
        {
            try
            {
                dbContext.Reservations.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Reservation Read(int key)
        {
            try
            {
                return dbContext.Reservations.FirstOrDefault(x => x.Id == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ICollection<Reservation> ReadAll()
        {
            try
            {
                return dbContext.Reservations.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Reservation item)
        {
            try
            {
                Reservation itemFromDb = Read(item.Id);
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
                Reservation itemFromDb = Read(key);
                if (itemFromDb != null)
                {
                    dbContext.Reservations.Remove(itemFromDb);
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
