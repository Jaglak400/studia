using System;
public class Program
{
    public static void Main(string[] args)
    {
        int liczba, i;
        int check = 0;

        Console.Write("Podaj liczbe: ");
        liczba = int.Parse(Console.ReadLine());

        for (i = 2; i <= liczba / 2; i++)
        {
            if (liczba % i == 0)
            {
                Console.Write("Liczba nie jest pierwsza.");
                check = 1;
                break;
            }
        }
        if (check == 0)
            Console.Write("Liczba pierwsza.");
    }
}