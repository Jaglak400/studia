using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class zadanie
{
    static void Main(string[] args)
    {
        int sum = 0;

        int count = 0;

        for(int i=1; i <= 16; i++)
        {
            count++;
            sum = sum + i;
            while (sum > 100)
            {
                Console.WriteLine(sum + " " + count);
                Console.ReadLine();
                break;
            }
        }
        }
}