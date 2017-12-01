using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstructFactory
{
    interface VehicleFactory
    {
        Bike GetBike(string Bike);
        Scooter GetScooter(string Scooter);
    }
}
