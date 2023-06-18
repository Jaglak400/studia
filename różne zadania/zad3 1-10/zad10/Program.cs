using System;


public class zad
{
    static void Main(string[] args)

    {
        Random random = new Random();

        int liczba = random.Next(1, 10);

        int zgaduj = 0;
        int count = 0;

        Console.WriteLine("Wylosowalem liczbe miedzy 1, a 1000, zganiesz co to za liczba?");

        do
        {
            zgaduj = Convert.ToInt32(Console.ReadLine());
            count++;
            if (zgaduj < liczba)
            {
                Console.WriteLine("Twoja liczba jest za mala");
            }
            else if (zgaduj > liczba)
            {
                Console.WriteLine("Twoja liczba jest za duza");
            }

        } while (zgaduj != liczba);

            Console.WriteLine("Trafiles! Liczba prób " + count);
        Console.ReadLine();

    }
}