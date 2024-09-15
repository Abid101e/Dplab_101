using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public void ManageDriver(Driver driver, bool isActive)
        {
            driver.Availability = isActive;
            Console.WriteLine($"Admin {Name} set driver {driver.Name}'s availability to {isActive}");
        }

        public void ManageRider(Rider rider, bool isActive)
        {
            Console.WriteLine($"Admin {Name} managed rider {rider.Name}.");
        }

        public void ViewTripHistory(Trip trip)
        {
            Console.WriteLine($"Admin {Name} viewing trip history for Trip {trip.Id}.");
        }

        public void HandleDispute(Rider rider, Driver driver)
        {
            Console.WriteLine($"Admin {Name} is handling dispute between rider {rider.Name} and driver {driver.Name}.");
        }
    }

}
