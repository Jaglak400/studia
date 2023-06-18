using System;

public class Test
{
    public static void Main()
    {
        int a, b, c;
        Console.WriteLine("Podaj Pierwsza Liczbe");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj Druga Liczbe");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj Trzecia Liczbe");
        c = Convert.ToInt32(Console.ReadLine());
        if (a > b && a>c)
        {
                Console.WriteLine("Max: {0}", a);
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("Max: {0}", b);
            }
            else
            {
                Console.WriteLine("Max: {0}", c);
            }
        }
    }
}