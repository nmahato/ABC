using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstructFactory
{

    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    class RegularBike : IBike
    {
        public string Name()
        {
            return "Regular Bike- Name";
        }
    }
}
