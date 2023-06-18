using System;
using System.Security.Cryptography;

class Middle
{


    public static void Main()
    {
        int x, y, z;
        Console.WriteLine("Podaj Pierwsza Liczbe");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj Druga Liczbe");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj Trzecia Liczbe");
        z = Convert.ToInt32(Console.ReadLine());

        if (x > y) 
        { 
            (x, y) = (y, x); 
        }
            
        if (x > z) 
        { 
            (x, z) = (z, x); 
        }
            
        if (y > z) 
        { 
            (y, z) = (z, y); 
        }
           
        Console.WriteLine("Posortowane wartosci: {0}, {1}, {2} ",x, y, z);

    }


}