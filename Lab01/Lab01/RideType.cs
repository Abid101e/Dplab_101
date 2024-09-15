using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class RideType
    {
        public string Type { get; private set; }
        public double BaseRate { get; private set; }

        
        private RideType(string type, double baseRate)
        {
            Type = type;
            BaseRate = baseRate;
        }

        
      
    }
}
