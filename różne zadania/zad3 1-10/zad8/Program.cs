using System;

public class zad
{
    static void Main(string[] args)
    {
        double x;
        do
        {
            Console.WriteLine("Podaj liczbe 2<:x:<3 ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x > 2 && x < 3)
            { 
                break;
            }
        } while(true);
    }
}