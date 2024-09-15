using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Trip
    {
        public int Id { get; set; }
        public string PickupLocation { get; set; }
        public string DropOffLocation { get; set; }
        public RideType RideType { get; set; }
        public string Status { get; set; }
        public double Fare { get; set; }
        public double Distance { get; set; }
        public Rider Rider { get; set; }
        public Driver Driver { get; set; }

        public void CalculateFare()
        {
            Fare = Distance * RideType.BaseRate;
            Console.WriteLine($"Fare calculated: {Fare}");
        }
    }
}
