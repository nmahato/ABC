using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstructFactory
{
    
 
/// <summary>
/// The 'ProductA2' class
/// </summary>
    class SportsBike : IBike
    {
        public string Name()
        {
            return "Sports Bike- Name";
        }
    }
}
