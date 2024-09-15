using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Rider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public PaymentMethod PreferredPaymentMethod { get; set; }

        public Trip RequestRide(string pickupLocation, string dropOffLocation, RideType rideType)
        {
            Console.WriteLine($"{Name} requested a {rideType} ride from {pickupLocation} to {dropOffLocation}.");
            return new Trip
            {
                PickupLocation = pickupLocation,
                DropOffLocation = dropOffLocation,
                RideType = rideType,
                Status = "Requested",
                Rider = this
            };
        }

        public void RateDriver(Driver driver, double rating)
        {
            driver.Rating = (driver.Rating + rating) / 2;
            Console.WriteLine($"{Name} rated driver {driver.Name} with {rating} stars.");
        }

        public void MakePayment(Trip trip)
        {
            PreferredPaymentMethod.ProcessPayment(trip.Fare);
        }
    }
}
