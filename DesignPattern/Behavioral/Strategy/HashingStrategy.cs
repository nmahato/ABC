using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Strategy
{
    public abstract class HashingStrategy
    {
        public abstract void HashingInterface(string text);
    }
}
