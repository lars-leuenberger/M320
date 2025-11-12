using System;

public class Bruch
{
    public int Zaehler { get; private set; }
    public int Nenner { get; private set; }

    public Bruch()
    {
        Zaehler = 0;
        Nenner = 1;
    }

    public Bruch(int zaehler, int nenner)
    {
        if (nenner == 0)
            throw new ArgumentException("Nenner darf nicht 0 sein!");

        Zaehler = zaehler;
        Nenner = nenner;
        Normiere();
        Kuerze();
    }

    public double AsDouble()
    {
        return (double)Zaehler / Nenner;
    }

    public Bruch BildeKehrwert()
    {
        if (Zaehler == 0)
            throw new DivideByZeroException("Kehrwert von 0 nicht definiert!");
        return new Bruch(Nenner, Zaehler);
    }

    public static Bruch Multipliziere(Bruch b1, Bruch b2)
    {
        return new Bruch(b1.Zaehler * b2.Zaehler, b1.Nenner * b2.Nenner);
    }

    public Bruch Multipliziere(Bruch b)
    {
        return new Bruch(Zaehler * b.Zaehler, Nenner * b.Nenner);
    }

    public Bruch Multipliziere(int f)
    {
        return new Bruch(Zaehler * f, Nenner);
    }

    public static Bruch Dividiere(Bruch b1, Bruch b2)
    {
        if (b2.Zaehler == 0)
            throw new DivideByZeroException("Division durch 0!");
        return new Bruch(b1.Zaehler * b2.Nenner, b1.Nenner * b2.Zaehler);
    }

    public Bruch Dividiere(Bruch b)
    {
        return Dividiere(this, b);
    }

    public Bruch Dividiere(int f)
    {
        if (f == 0)
            throw new DivideByZeroException("Division durch 0!");
        return new Bruch(Zaehler, Nenner * f);
    }

    public static Bruch Addiere(Bruch b1, Bruch b2)
    {
        int nenner = b1.Nenner * b2.Nenner;
        int zaehler = b1.Zaehler * b2.Nenner + b2.Zaehler * b1.Nenner;
        return new Bruch(zaehler, nenner);
    }

    public Bruch Addiere(Bruch b)
    {
        return Addiere(this, b);
    }

    public Bruch Addiere(int a)
    {
        return new Bruch(Zaehler + a * Nenner, Nenner);
    }

    public static Bruch Subtrahiere(Bruch b1, Bruch b2)
    {
        int nenner = b1.Nenner * b2.Nenner;
        int zaehler = b1.Zaehler * b2.Nenner - b2.Zaehler * b1.Nenner;
        return new Bruch(zaehler, nenner);
    }

    public Bruch Subtrahiere(Bruch b)
    {
        return Subtrahiere(this, b);
    }

    public Bruch Subtrahiere(int a)
    {
        return new Bruch(Zaehler - a * Nenner, Nenner);
    }

    public Bruch Erweitere(int f)
    {
        return new Bruch(Zaehler * f, Nenner * f);
    }

    private void Kuerze()
    {
        int gcd = GGT(Math.Abs(Zaehler), Math.Abs(Nenner));
        Zaehler /= gcd;
        Nenner /= gcd;
    }

    private void Normiere()
    {
        if (Nenner < 0)
        {
            Nenner *= -1;
            Zaehler *= -1;
        }
    }

    private static int GGT(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{Zaehler}/{Nenner}";
    }

    public static Bruch operator *(Bruch b1, Bruch b2) => Multipliziere(b1, b2);
    public static Bruch operator /(Bruch b1, Bruch b2) => Dividiere(b1, b2);
    public static bool operator ==(Bruch b1, Bruch b2) => b1.Equals(b2);
    public static bool operator !=(Bruch b1, Bruch b2) => !b1.Equals(b2);

    public override bool Equals(object obj)
    {
        if (obj is Bruch b)
            return Zaehler == b.Zaehler && Nenner == b.Nenner;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Zaehler, Nenner);
    }
}
