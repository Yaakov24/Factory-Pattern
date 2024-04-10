using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
       public static IVehicle GetVehicle(int tires)
        {
            if (tires == 2  || tires == 1)
            {
                return new Motorcycle();
            }
            else
            {
                return new Truck();
            }
        }   
    }
}
