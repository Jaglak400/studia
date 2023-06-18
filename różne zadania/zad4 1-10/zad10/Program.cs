
using System;
public class zad
{
    public static void Main()
    {
        int n, sum;
 
        Console.Write("Liczby doskonałe w przedziale <1,10000>: ");

        for (int i = 1; i <= 10000; i++)
        {
            n = 1;
            sum = 0;
            while (n < i)
            {
                if (i % n == 0)
                {
                    sum += n;
                }
                n++;
            }
            if (sum == i)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}