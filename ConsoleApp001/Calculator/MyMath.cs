/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            int z;

            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        public static int Calc_kgV(int a, int b)
        {
            int kgv = (a * b) / (Calc_ggT(a, b));
            return kgv;
        }
    }
}*/

using System;

namespace Calculator
{
    internal class MyMath
    {
        // ----- Eingaben & Ausgabe -----

        // Liest eine positive ganze Zahl (>0). Fragt solange nach, bis gültig.
        public static int ReadInt(string prompt = "Geben Sie eine Zahl ein: ")
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int value) && value > 0)
                    return value;

                Console.WriteLine("Bitte eine POSITIVE ganze Zahl (> 0) eingeben!");
            }
        }

        // Formattierte Resultat-Ausgabe gemäss Aufgabenstellung
        // op: "ggT" oder "kgV"
        public static void ShowResult(string op, int a, int b, int result)
        {
            if (op.Equals("ggT", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"ggT von {a} und {b} ist {result}");
            else if (op.Equals("kgV", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"kgV von {a} und {b} ist {result}");
            else
                Console.WriteLine($"{op} von {a} und {b} ist {result}");
        }

        // ----- ggT / kgV -----

        // Iterativer Euklidischer Algorithmus
        public static int Calc_ggT(int a, int b)
        {
            while (b != 0)
            {
                int rest = a % b;
                a = b;
                b = rest;
            }
            return a;
        }

        // Rekursive Variante: ggT(a,b) = ggT(b, a mod b); ggT(a,0) = a
        public static int Calc_ggT_r(int a, int b)
        {
            return (b == 0) ? a : Calc_ggT_r(b, a % b);
        }

        // kgV über Zusammenhang: ggT(a,b) * kgV(a,b) = a * b
        public static int Calc_kgV(int a, int b)
        {
            // Annahme: a,b > 0 (durch ReadInt abgesichert)
            return (a / Calc_ggT(a, b)) * b;
        }

        // ----- Array-Funktionen -----

        // Liest n Werte in ein Array
        public static int[] ReadArray(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = ReadInt($"Wert {i + 1}: ");
            }
            return arr;
        }

        public static double Mean(int[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++) sum += arr[i];
            return arr.Length == 0 ? 0.0 : (double)sum / arr.Length;
        }

        public static int Min(int[] arr)
        {
            if (arr.Length == 0) throw new ArgumentException("Array ist leer.");
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min) min = arr[i];
            return min;
        }

        public static int Max(int[] arr)
        {
            if (arr.Length == 0) throw new ArgumentException("Array ist leer.");
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max) max = arr[i];
            return max;
        }

        // Vertauscht die Inhalte zweier Variablen (per ref)
        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        // Kehrt ein Array in-place um
        public static void Reverse(int[] arr)
        {
            int i = 0, j = arr.Length - 1;
            while (i < j)
            {
                Swap(ref arr[i], ref arr[j]);
                i++; j--;
            }
        }

        // Einfache stabile Sortierung (Bubble Sort) – bewusst selbst implementiert
        public static void Sort(int[] arr)
        {
            bool swapped;
            int n = arr.Length;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        Swap(ref arr[i - 1], ref arr[i]);
                        swapped = true;
                    }
                }
                n--; // letztes Element ist danach sicher am Platz
            } while (swapped);
        }
    }
}
