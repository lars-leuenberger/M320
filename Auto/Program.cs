using System.Runtime.CompilerServices;

namespace AutoAnlassen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            Benzinpumpe benzinpumpe = new Benzinpumpe();
            Anlasser anlasser = new Anlasser();
            Motor motor = new Motor();

            auto.Anlassen(motor, benzinpumpe, anlasser);
        }
    }
}
