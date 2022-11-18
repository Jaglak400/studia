using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
    class Program
    {

        static void Main(string[] args)
        {
            int liczba = (-1);
            for (int n = 0; n <= 100; n++)

            {
                Console.WriteLine((Math.Pow(liczba, n)) / ((2 * n) + 1));
            }

            Console.ReadKey();
        }
    }
