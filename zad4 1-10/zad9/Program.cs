using System;

public class Program
{

    public static void Main(string[] args)
    {
        int i;
        int num = 100; 
        int sum = 0;

        for (i = 0; i <= num; i++)
        {   
            if(i % 2 != 0) continue;

            sum += i;
        }

        Console.WriteLine("Nigga " + num + " is: " + sum);
    }
}
