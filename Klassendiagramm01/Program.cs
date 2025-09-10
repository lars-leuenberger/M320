using System.Runtime.CompilerServices;

namespace Klassendiagramm01
{
    internal class Program
    {
        public class AttributMix
        {
            private int einnahme;

            public int ausgabe;

            public double zins = 2.00;

            private bool gemahnt;

            protected int anzahl;

            internal string name = "Meier";

            private int guthaben;

            public readonly int jahrgang;
        }

        public class OperationenMix
        {
            public void leseZahl() { }
            public void println() { }
            private int addiere(int a, int b) { return a + b; }
        }
    }
}
