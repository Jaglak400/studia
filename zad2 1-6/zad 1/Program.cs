using System;
using System.ComponentModel.DataAnnotations;

class GFG
{

    public static void Main()
    {
        double x = Math.Pow(Math.Sqrt(2), Math.Sqrt(3));
        double y = Math.Pow(Math.Sqrt(3), Math.Sqrt(2));
        Console.WriteLine("Wynik: {0} i {1}", x ,y);
        Console.WriteLine("Wieksza liczba to: " + Math.Max(x, y));

    }
}