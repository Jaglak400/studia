using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int jeden, dwa, piec = 0;

            {
                for (jeden = 0; jeden <= 10; jeden++)
                {
                    for (dwa = 0; dwa <= 10; dwa++)
                    {
                        for (piec = 0; piec <= 10; piec++)
                        {
                            if (jeden * 1 + dwa * 2 + piec * 5 == 10)
                            {
                                Console.WriteLine("zlotowka = {0} dwa zlote = {1} piec zlote = {2}", jeden, dwa, piec);
                            }
                        }
                    }
                }
            }
        }
    }
}