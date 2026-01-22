using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Data
{
    public class Database
    {
        public static List<Client> Clients { get; set; } = new List<Client>();
        public static List<Location> Locations { get; set; } = new List<Location>();

        public static void StartDataBase()
        {
            Clients.Add(new Client()
            {
                ClientId = 1,
                ClientName = "Tolgam",
                LocationId = 1,
            });
            Clients.Add(new Client()
            {
                ClientId = 2,
                ClientName = "Berkem",
                LocationId = 2,
            });
            Locations.Add(new Location()
            {
                LocationId = 1,
                City = "Genk",
                PostCode = "3600"
            });
            Locations.Add(new Location()
            {
                LocationId = 2,
                City = "Hasselt",
                PostCode = "3500"
            });

        }
    }
}
