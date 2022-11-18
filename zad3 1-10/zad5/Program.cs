using System;

    internal class Program
    {
        static void Main()
        {
            double kapital = 10000;
            double procent = 0.05;
            int lata = 12;
            double suma = 0;
            
            for (int i = 0; i < 12; i++)
            {
                suma = kapital * procent / lata;
                kapital += suma;
            }

            kapital = (double)System.Math.Round(kapital,2);
            Console.WriteLine("razem {0}", kapital);
        }
    }
