using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Strategy
{
    public class Client
    {
        public Client()
        {
            HashingContext context;

             context = new HashingContext(new SHA1Hashing());
             context.HashPassword("test");

            context = new HashingContext(new SHA384Hashing());
            context.HashPassword("Chinna Lohetha");
        }
    }
}
