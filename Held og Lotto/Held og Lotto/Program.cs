using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Held_og_Lotto

{

    public class Program

    {

        static void Main(string[] args)

        {

            Random random = new Random(15);



            for (int i = 0; i < 7; i++)

            {



                int number = random.Next(2, 36);



                if (number == 9)

                {

                    Console.ForegroundColor = ConsoleColor.Red;

                }



                else

                {

                    Console.ForegroundColor = ConsoleColor.White;

                }



                Console.Write(number + "\t");



                Task.Delay(2000).Wait();

            }

            Console.WriteLine();



            Console.ReadKey();



        }

    }

}

