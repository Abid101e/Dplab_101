using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class PayPal : PaymentMethod
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via PayPal.");
        }
    }
}
