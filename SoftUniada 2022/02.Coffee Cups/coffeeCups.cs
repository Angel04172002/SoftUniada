using System;

namespace CoffeeCups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string label = Console.ReadLine();
            PrintCoffeeCup(n, label);
        }

        static void PrintCoffeeCup(int n, string label)
        {
            for(int i = 0; i < n; i++)
            {
                if (i >= 1)
                {
                    for(int q= 1; q<= n; q++)
                    {
                        Console.Write(" ");
                    }
                }

                for(int k = 0; k < 3; k++)
                {
                    if (k != n - 1)
                    {
                        Console.Write("~ ");
                    }
                    else
                    {
                        Console.Write("~");
                    }
                }

                Console.WriteLine();
            }

            for(int i = 0; i < 3 * n + 5; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();
            
            int middle = (n - 2) / 2;

            for(int i = 0; i < n - 2; i++)
            {
                Console.Write("|");

                if (i == middle)
                {
                    for(int m = 1; m <= n; m++)
                    {
                        Console.Write("~");
                    }

                    Console.Write(label.ToUpper());

                    for (int m = 1; m <= n; m++)
                    {
                        Console.Write("~");
                    }
                }
                else
                {
                    for (int k = 1; k <= (n * 2) + 4; k++)
                    {
                        Console.Write("~");
                    }
                }

                Console.Write("|");

                for(int g = 1; g <= n - 2 + 1; g++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");

                Console.WriteLine();
            }

            for (int i = 0; i < 3 * n + 5; i++)
            {
                Console.Write("=");
            }


            Console.WriteLine();
            
            int v = 0;

            for(int i = 0; i < n; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }

                Console.Write("\\");

                for(int k = 1; k <= (n * 2) + 4 - v; k++)
                {
                    Console.Write("@");
                }


                Console.Write("/");

                Console.WriteLine();
                v += 2;
            }    


            for(int i = 0; i < 3 * n + 5; i++)
            {
                Console.Write("-");
            }
        }
    }
}



