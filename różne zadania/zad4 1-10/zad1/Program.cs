using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double godziny,i;
            char wynik;
            double a = 50;
            double b = 0.45;
            double suma = 0;
            double podst = 0;
            Console.WriteLine("Który wariant wybierasz, a czy b <b to 50zl>?");
            wynik = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ile Godzin");
            godziny = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= godziny; i++)
            {
                switch (wynik)
                {
                    case 'a':
                        suma += a;
                        break;
                    case 'b':
                        podst = b + b;
                        b = podst;
                        suma = b * godziny / 2;
                        break;
                }
            }
            Console.WriteLine(suma);
        }
    }
}