using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juletræet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 10;

            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < (2 * i + 1); k++)
                {
                    if (i % 2 == 0 && k % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("o");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (i % 2 == 0 && k % 2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("o");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write("o");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}