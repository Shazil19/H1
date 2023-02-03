using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace The_Josephus_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //The program starts with a while loop that keeps repeating until the user decides to end the game.

            while (true)
            {
                Console.ReadKey();

                Console.Clear();

                //The user is prompted to enter the number of soldiers and the execution interval in each iteration of the loop.

                Console.Write("The number of soldiers:\t\t");

                int n = int.Parse(Console.ReadLine());

                Console.Write("and the execution interval:\t");

                int k = int.Parse(Console.ReadLine());

                Console.Clear();

                //Once the input is taken, the program shows a loading animation of ten dots to make the user wait for the solution.


                for (int j = 0; j < 10; j++)
                {

                    //This is done using the Thread.Sleep function which makes the program wait for 500 milliseconds after printing each dot.

                    Thread.Sleep(500);

                    Console.Write(".");
                }

                Console.Clear();

                //The actual calculation of the solution is done by the FindSurvivor function, which takes the number of soldiers (n) and the execution interval (k) as inputs.

                int result = FindSurvivor(n, k);

                Console.WriteLine("The chosen position is: " + result);

                //If the user chooses to play again, the loop starts over, and the user can input new values for n and k. If the user types 'N', the program terminates.

                Console.Write("If you don't want to play again just type (N) or else the game will restart if you click enter\t");

                string reply = Console.ReadLine();

                reply = reply.ToUpper();

                if (reply == "N")
                {
                    break;
                }
            }
        }


        static int FindSurvivor(int n, int k)
        {

            //This function uses a simple mathematical formula to find the survivor's position.

            int survivor = 0;
            for (int i = 1; i <= n; i++)
            {

                //The formula is survivor = (survivor + k) % i, where survivor is the survivor's position, k is the execution interval, and i is the current iteration number.

                survivor = (survivor + k) % i;
            }
            return survivor + 1;
        }
    }
}

