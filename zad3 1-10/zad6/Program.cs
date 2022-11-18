using System;
public class zad
{
    public static void Main(string[] args)
    {
        int n1 = 0;
        int n2 = 1; 
        int n3, i, number;

        Console.Write("Podaj liczbe: ");
        number = int.Parse(Console.ReadLine());
        Console.Write(n1 + " " + n2 + " "); 

        for (i = 2; i < number; ++i) 
        {
            n3 = n1 + n2;
            n1 = n2;
            n2 = n3;
            Console.Write(n3 + " ");
        }
    }
}