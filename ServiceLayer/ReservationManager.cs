using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    class ReservationManager
    {
        private static ReservationsContext reservationContext;
        public ReservationManager(RestaurantDbContext dbContext)
        {
            reservationContext = new ReservationsContext(dbContext);
        }

        public static void Create(Reservation reservation)
        {
            try
            {
                reservationContext.Create(reservation);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Reservation Read(int key)
        {
            try
            {
                return reservationContext.Read(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ICollection<Reservation> ReadAll()
        {
            try
            {
                return reservationContext.ReadAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Update(Reservation item)
        {
            try
            {
                reservationContext.Update(item);
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
                reservationContext.Delete(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
