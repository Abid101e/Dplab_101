using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public static class NotificationService
    {
        public static void SendNotification(Rider rider, string message)
        {
            Console.WriteLine($"Notification to {rider.Name}: {message}");
        }

        public static void SendNotification(Driver driver, string message)
        {
            Console.WriteLine($"Notification to {driver.Name}: {message}");
        }
    }

}
