using Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAnlassen
{
    internal class Auto
    {
        public void Anlassen(Motor motor, Benzinpumpe benzpumpe, Anlasser anlasser)
        {
            Console.WriteLine("Auto anlassen");
            motor.Starten(benzpumpe, anlasser);
        }
    }
}
