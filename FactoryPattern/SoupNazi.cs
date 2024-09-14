using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class SoupNazi : IVehicle
    {
        public void Build()
        {
            Console.WriteLine("No vehicle for you!");
        }
    }
}
