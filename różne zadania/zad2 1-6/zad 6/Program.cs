using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class MyApplication
    {
        static void Main(string[] args)
        {
        Random rand = new Random();
        int num = rand.Next(1, 999);

            Console.WriteLine("Liczba: " + num);

            if (num % 3 == 0)
            {
                Console.WriteLine("Podzielna przez 3");
            }
            else
            {
                Console.WriteLine("Nie podzielna przez 3");
            }
            Console.ReadLine();
        }
    }
