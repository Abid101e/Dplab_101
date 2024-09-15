using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class DigitalWallet : PaymentMethod
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via Digital Wallet.");
        }
    }
}
