using BusinessLayer;
using DataLayer;

namespace TestingLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Id= 1;
            client.Name= "Test";
            client.Age = 30;
            client.Reservations = new List<Reservation>();
            Reservation reservation = new Reservation();
            reservation.Id = 1;
            reservation.Address = "Test";
            reservation.Restaurant = new Restaurant();
            reservation.Restaurant.Address= "Test";
            reservation.Restaurant.Name= "Test";
            reservation.Restaurant.YearlyProfit = 30;
            reservation.Price = 30;
            reservation.Days = 30;
            ClientsContext clientsContext = new ClientsContext(new RestaurantsDbContext());
            ReservationsContext reservationsContext = new ReservationsContext(new RestaurantsDbContext());
            clientsContext.Create(client);
            reservationsContext.Create(reservation);
        }
    }
}