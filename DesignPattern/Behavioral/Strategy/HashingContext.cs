using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Strategy
{
    public class HashingContext
    {
        private HashingStrategy _hashingStrategy;

        public HashingContext(HashingStrategy hashingStrategy)
        {
            _hashingStrategy = hashingStrategy;
        }
        public void HashPassword(string text)
        {
            _hashingStrategy.HashingInterface(text);
        }
    }
}
