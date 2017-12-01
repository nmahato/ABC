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
            Console.WriteLine("Select a design pattern :");
            Console.WriteLine("");
             Console.WriteLine("1.  Strategy:");
             Console.WriteLine("2. Command :");
            Console.WriteLine("");
          var opt=  Console.ReadLine();

            switch (opt)
            {
                case "1":
                    var stetegy = new Behavioral.Strategy.Client();
                    break;
                case "2":
                     var cmd = new Behavioral.Command.Client();
                     break;
                
            }

              Console.ReadKey();

           

             Console.ReadKey();
        }
    }
}
