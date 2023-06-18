using System;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;

public class zad
{
    static void Main(string[] args)
    {
        int liczba;
        int i = 1;
        Console.WriteLine("Podaj liczbe calkowita");
        liczba = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        do
        {

            if (liczba % i == 0)
                Console.WriteLine(i);
                i++;
        } while (i <= liczba);
        Console.ReadKey();

    }
}

