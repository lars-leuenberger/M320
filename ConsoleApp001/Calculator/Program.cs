/*namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowResult();
        }

        public static int ReadInt()
        {
            
            int Zahl1 = 0;
            while (true)
            {
                Console.WriteLine("Geben Sie eine Zahl ein: ");
                Zahl1 = Convert.ToInt32(Console.ReadLine());

                if (Zahl1 >= 0)
                {
                    return Zahl1;
                }
                else
                {
                    Console.WriteLine("Geben Sie eine positive Zahl ein!");
                }
            }
        }

        public static void ShowResult()
        {
            int a = ReadInt();
            int b = ReadInt();
            int ggt = MyMath.Calc_ggT(a, b);
            int kgv = MyMath.Calc_kgV(a, b);
            Console.WriteLine($"ggT von {a} und {b} ist {ggt}");
            Console.WriteLine("respektive");
            Console.WriteLine($"kgV von {a} und {b} ist {kgv}");
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interaktives Menü bis zum Abbruch
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== Rechner Menü ===");
                Console.WriteLine("1) ggT berechnen");
                Console.WriteLine("2) kgV berechnen");
                Console.WriteLine("3) Array-Auswertung (Mittelwert / Min / Max)");
                Console.WriteLine("4) Swap zweier Zahlen");
                Console.WriteLine("5) Array umkehren");
                Console.WriteLine("6) Array sortieren");
                Console.WriteLine("0) Beenden");
                Console.Write("Ihre Wahl: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "0") break;

                switch (choice)
                {
                    case "1": // ggT
                        {
                            int a = MyMath.ReadInt("Erste Zahl (a) > 0: ");
                            int b = MyMath.ReadInt("Zweite Zahl (b) > 0: ");
                            // sowohl iterative als auch rekursive Variante
                            int ggtIter = MyMath.Calc_ggT(a, b);
                            int ggtRek = MyMath.Calc_ggT_r(a, b);
                            MyMath.ShowResult("ggT", a, b, ggtIter);
                            Console.WriteLine($"(rekursiv berechnet: {ggtRek})");
                            break;
                        }
                    case "2": // kgV
                        {
                            int a = MyMath.ReadInt("Erste Zahl (a) > 0: ");
                            int b = MyMath.ReadInt("Zweite Zahl (b) > 0: ");
                            int kgv = MyMath.Calc_kgV(a, b);
                            MyMath.ShowResult("kgV", a, b, kgv);
                            break;
                        }
                    case "3": // Array-Auswertung
                        {
                            int n = MyMath.ReadInt("Wie viele Werte möchten Sie eingeben? ");
                            int[] arr = MyMath.ReadArray(n);
                            double mean = MyMath.Mean(arr);
                            int min = MyMath.Min(arr);
                            int max = MyMath.Max(arr);
                            Console.WriteLine($"Eingegebenes Array: {string.Join(", ", arr)}");
                            Console.WriteLine($"Arithm. Mittelwert: {mean}");
                            Console.WriteLine($"Kleinster Wert:     {min}");
                            Console.WriteLine($"Grösster Wert:      {max}");
                            break;
                        }
                    case "4": // Swap
                        {
                            int a = MyMath.ReadInt("Zahl 1: ");
                            int b = MyMath.ReadInt("Zahl 2: ");
                            Console.WriteLine($"Vor Swap: a={a}, b={b}");
                            MyMath.Swap(ref a, ref b);
                            Console.WriteLine($"Nach Swap: a={a}, b={b}");
                            break;
                        }
                    case "5": // Reverse
                        {
                            int n = MyMath.ReadInt("Anzahl Werte fürs Array: ");
                            int[] arr = MyMath.ReadArray(n);
                            Console.WriteLine("Vorher:  " + string.Join(" ", arr));
                            MyMath.Reverse(arr);
                            Console.WriteLine("Nachher: " + string.Join(" ", arr));
                            break;
                        }
                    case "6": // Sort
                        {
                            int n = MyMath.ReadInt("Anzahl Werte fürs Array: ");
                            int[] arr = MyMath.ReadArray(n);
                            Console.WriteLine("Vorher:  " + string.Join(" ", arr));
                            MyMath.Sort(arr); // einfache Bubblesort-Implementierung
                            Console.WriteLine("Nachher: " + string.Join(" ", arr));
                            break;
                        }
                    default:
                        Console.WriteLine("Ungültige Auswahl.");
                        break;
                }
            }

            Console.WriteLine("Programm beendet. Drücken Sie eine Taste …");
            Console.ReadKey();
        }
    }
}
