using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Behavioral;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var stetegy = new Behavioral.Strategy.Client();

            var cmd = new Behavioral.Command.Client();

             Console.ReadKey();
        }
    }
}
