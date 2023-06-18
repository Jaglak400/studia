using System;
public class Test
{
    public static void Main()
    {
        int a, n, i;
        double w = 0.0;
        n = 2;

        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Podaj liczbe:");
            a = int.Parse(Console.ReadLine());
            w += a;
        }
        Console.WriteLine(w / n);
    }
}
