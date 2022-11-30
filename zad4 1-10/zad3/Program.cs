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
                for (jeden = 0; jeden <= 1000; jeden++)
                { 
                    for (dwa = 0; dwa <= 500; dwa++)
                    {
                        for (piec = 0; piec <= 200; piec++)
                        {
                            if (jeden * 1 + dwa * 2 + piec * 5 == 1000 && jeden == dwa && piec == dwa && piec == jeden)
                            {
                                Console.WriteLine("Ilość pieniędzy żeby bylo równo: złotówka: {0} dwa złote: {1} pięć złotych: {2}", jeden, dwa, piec);
                            }
                        }
                    }
                }
            }
        }
    }
}