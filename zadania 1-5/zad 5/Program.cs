using System;

public class Program
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Współczynnik a nie może być zerem.");
            return;
        }

        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("delta < 0, brak rozwiazan");
            return;
        }

        if (delta == 0)
        {
            int x = -b / 2 * a;
            Console.WriteLine("delta = 0, jeden pierwiastek: " + x);
            return;
        }

        int deltaSqrt = (int)Math.Sqrt(delta);

        int x1 = (-b - deltaSqrt) / 2 * a;
        int x2 = (-b + deltaSqrt) / 2 * a;

        Console.WriteLine("delta > 0, dwa pierwiastki, x1 = " + x1 + ", x2 = " + x2);
    }
}