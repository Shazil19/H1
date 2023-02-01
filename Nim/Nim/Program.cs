using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matches = 7;
            int turn = 1; // 1 for human, 0 for computer

            while (matches > 0)
            {
                Console.WriteLine("There are " + matches + " matches on the table.");
                if (turn == 1)
                {
                    Console.Write("Enter number of matches you want to pick up (1-3): ");
                    int pick = Convert.ToInt32(Console.ReadLine());
                    if (pick < 1 || pick > 3)
                    {
                        Console.WriteLine("Invalid input. You must pick 1 to 3 matches.");
                        continue;
                    }
                    if (pick > matches)
                    {
                        Console.WriteLine("Invalid input. You cannot pick more matches than what is on the table.");
                        continue;
                    }
                    matches -= pick;
                }
                else
                {
                    int pick = (matches - 1) % 4;
                    if (pick == 0) pick = 1;
                    Console.WriteLine("Computer picked up " + pick + " match(es).");
                    matches -= pick;
                }

                if (matches <= 0)
                {
                    if (turn == 1) Console.WriteLine("You lost the game.");
                    else Console.WriteLine("You won the game.");
                    break;
                }

                turn = (turn == 1) ? 0 : 1;
            }
        }
    }
}