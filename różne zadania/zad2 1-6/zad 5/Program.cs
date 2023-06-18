using System;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

                double res;
                Console.Write("Liczba 1:");
                double num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Liczba 2:");
                double num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Wybierz operacje: \r\n" +
                    "'*' - mnożenie         '/' - dzielenie \r\n" +
                    "'+' - dodawanie        '-' - odejmowanie \r\n" +
                    "'^' - potegowanie      '%' - modulo \r\n");

                char symbol = Convert.ToChar(Console.ReadLine());
                

                switch (symbol)
                {
                    case '+':
                        res = num1 + num2;
                        Console.WriteLine("Dodawanie:" + res);
                        break;

                    case '-':
                        res = num1 - num2;
                        Console.WriteLine("Odejmowanie:" + res);
                        break;

                    case '*':
                        res = num1 * num2;
                        Console.WriteLine("Możenie:" + res);
                        break;

                    case '/':
                        res = num1 / num2;
                        Console.WriteLine("Dzielenie:" + res);
                        break;

                    case '^':
                        res = Math.Pow(num1, num2);
                        Console.WriteLine("Potęgowanie:" + res);
                        break;

                    case '%':
                         res = num1 % num2;
                         Console.WriteLine("Dzielenie modulo:" + res);
                         break;

                    default:
                        Console.WriteLine("Złe dane");
                        break;
                }
                Console.ReadLine();

            }

    }

