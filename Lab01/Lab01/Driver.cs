using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VehicleType { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public bool Availability { get; set; }

        public void AcceptRide(Trip trip)
        {
            trip.Driver = this;
            trip.Status = "Accepted";
            Console.WriteLine($"{Name} accepted the ride.");
            NotificationService.SendNotification(trip.Rider, "Your driver is on the way!");
        }

        public void RateRider(Rider rider, double rating)
        {
            rider.Rating = (rider.Rating + rating) / 2;
            Console.WriteLine($"{Name} rated rider {rider.Name} with {rating} stars.");
        }

        public void StartTrip(Trip trip)
        {
            trip.Status = "In Progress";
            Console.WriteLine($"Trip started by {Name}.");
        }

        public void CompleteTrip(Trip trip)
        {
            trip.Status = "Completed";
            Console.WriteLine($"Trip completed by {Name}. Fare: {trip.Fare}");
            trip.Rider.MakePayment(trip);
        }
    }

    }

