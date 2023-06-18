using System;

class Middle
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
        if ((a == b) || (c == a) || (c == b))
        {
            Console.WriteLine("Liczby nie moga byc takie same");
            return;
            
        }

        if ((a < b && b < c) || (c < b && b < a))
        {
            Console.WriteLine(b);
        }

        else if ((b < a && a < c) || (c < a && a < b))
        {
            Console.WriteLine(a);

        }
        else
        {
            Console.WriteLine(c);
        }



        Console.WriteLine((a, b, c));
    }
}