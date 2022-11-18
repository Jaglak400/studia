using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class zadanie
{
    static void Main(string[] args)
    {
        int n;
        int x = 0;
        int wynik = 0;

        Console.WriteLine("Podaj Liczbe n");
        n = Convert.ToInt32(Console.ReadLine());

        x = n;

        while (x >= 1)
        {
            Console.WriteLine("x = " + x + " " + " wynik = " + wynik);
            wynik = wynik + x;
            x--;


        }

        Console.WriteLine("\n Suma = " + wynik);
    }
}