using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAnlassen
{
    internal class Motor
    {


        public void Starten(Benzinpumpe benzpumpe, Anlasser anlasser)
        {
            Console.WriteLine("Motor starten");
            benzpumpe.pumpen();
            anlasser.starten();
            regeln(anlasser);
        }

        private void regeln(Anlasser anlasser)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Motor regeln");
            }
            anlasser.stoppen();
        }
    }
}
