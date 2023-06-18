using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace dxd
{
    class Program
    {
        static void Main(string[] args)
        {
            int rzad = 5;
            int i, j, k;
            for (i = 1; i <= rzad; i++)
            {
                for (j = 1; j <= rzad - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}