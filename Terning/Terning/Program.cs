using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.BackgroundColor = ConsoleColor.Black;

            Random random = new Random();
            
            int dice = random.Next(1, 7);

            if (dice == 1)
            {   
                Console.Write("Du slog en etter");
            }
            else if (dice == 2)
            {
                Console.Write("Du slog en to'er");
            }
            else if (dice == 3)
            {
                Console.Write("Du slog en to'er");
            }
            else if (dice == 4)
            {
                Console.Write("Du slog en to'er");
            }
            else if (dice == 5)
            {
                Console.Write("Du slog en to'er");
            }
            else if (dice == 6)
            {
                Console.Write("Du slog en to'er");
            }

            Console.WriteLine(dice);
        }
    }
}
