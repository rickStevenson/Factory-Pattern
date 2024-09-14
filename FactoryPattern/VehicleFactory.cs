using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "unicycle":
                    return new Unicycle();
                case "motorcycle":
                    return new Motorcycle();
                case "three wheeler":
                    return new ThreeWheeler();
                case "Car":
                    return new Car();
                default:
                    return new SoupNazi();
            }
        }
    }
}
