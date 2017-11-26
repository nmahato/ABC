﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Command
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on");
        }
        public void TurnOff()
        {
            Console.WriteLine("The light is off");
        }
    }
}
