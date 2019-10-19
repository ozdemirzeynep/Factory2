using System;
using System.Collections.Generic;
using System.Text;

namespace Factory2
{
    public class Cooling : AirConditioner
    {
        public override void Run()
        {
            Console.WriteLine("Cooling");
        }
    }
}
