using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class zadanie
{
    public static void Main()
    {
        int sum = 0, n = 0, count = 0;
        int max = 100;
        while (sum < max)
        {
            n = Convert.ToInt32(Console.ReadLine());
            sum += n;
            count++;
        }
        Console.WriteLine("Suma : " + sum + " Dodane liczby: " + count);
    }
}