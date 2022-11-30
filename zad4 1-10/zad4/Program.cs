using System;
namespace PatternDemo
{
    public class HalfPyramidOfNumbersPattern
    {
        public static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\r");
            }
            Console.ReadKey();
        }
    }
}