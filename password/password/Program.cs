using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Choose type of password that you would like to set");
            Console.WriteLine("1. Generic password\n2. Generic password with unique characters\n3.Generic password without special characters");
            string choose = Console.ReadLine();
            Console.Clear();
            var random = new Random();
            Console.WriteLine("Please provide the password length");
            int passwordLenght = 0;
            try
            {
                passwordLenght = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("unwanted int value");

            }

            while (true)
            {

                if (choose == "1")
                {







                    while (true)
                    {
                        var buffer = new char[passwordLenght];
                        var charCandidate = (char)('!' + random.Next(0, 89));

                        for (var i = 0; i < passwordLenght; i++)
                        {
                            charCandidate = (char)('!' + random.Next(0, 89));

                            while (charCandidate == '<' || charCandidate == ',' || charCandidate == '`')
                            {
                                charCandidate = (char)('!' + random.Next(0, 89));
                            }


                            buffer[i] = charCandidate;
                        }
                        var password = new string(buffer);
                        Console.WriteLine(password);

                        break;
                    }
                }


                else if (choose == "2")
                {


                    while (true)
                    {
                        var buffer = new char[passwordLenght];
                        for (var i = 0; i < passwordLenght; i++)
                        {
                            var charCandidate = (char)('!' + random.Next(0, 89));
                            while (buffer.Contains(charCandidate))
                            {
                                charCandidate = (char)('!' + random.Next(0, 89));
                            }

                            while (charCandidate == '<' || charCandidate == ',' || charCandidate == '`')
                            {
                                charCandidate = (char)('!' + random.Next(0, 89));
                            }

                            buffer[i] = charCandidate;
                        }
                        var password = new string(buffer);
                        Console.WriteLine(password);

                        break;
                    }
                }

                else if (choose == "3")
                {




                    while (true)
                    {


                        var buffer = new char[passwordLenght];
                        string passwordChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                        for (int i = 0; i < passwordLenght; i++)
                        {
                            buffer[i] = passwordChars[random.Next(passwordChars.Length)];
                        }

                        Console.WriteLine("Generated password: " + new string(buffer));
                        break;
                    }
                }


                //var password = new string(buffer);
                //Console.WriteLine(password);

                //break;


                else
                {
                    Console.WriteLine("Wrong input value");
                    Console.ReadKey();
                    Console.Clear();

                }
                Console.WriteLine("Hit enter to stop the password generator or 'x' to continue");
                var input = Console.ReadLine();
                Console.Clear();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
                else if (input == "x")
                {
                    Console.WriteLine("Choose type of password that you would like to set");
                    Console.WriteLine("1. Generic password \n2. Generic password with unique characters\n 3.Generic password without special characters");
                    choose = Console.ReadLine();
                    Console.WriteLine("Please provide the password length");
                    try
                    {
                        passwordLenght = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Unwanted int value");
                    }

                    Console.Clear();
                    continue;
                }
                Console.ReadLine();
            }


        }





    }
}