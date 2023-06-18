using System;


public class zad
{
    static void Main(string[] args)
    {
        int liczba, wykladnik, i, potega;

        Console.Write("Podaj liczbe: ");
        liczba = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj wykladnik: ");
        wykladnik = Convert.ToInt32(Console.ReadLine());

        potega = 1;
        for (i = 1; i <= wykladnik; i++)
        {
            potega = potega * liczba;
        }

        Console.Write("Potega : " + potega);
        Console.ReadLine();
    }
}