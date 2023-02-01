using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Rumfanget

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.Write("Please type the length of the cube: ");



            int lenght = int.Parse(Console.ReadLine());



            Console.Write("Please type the width of the cube: ");



            int width = int.Parse(Console.ReadLine());



            Console.Write("Please type the height of the cube: ");



            int height = int.Parse(Console.ReadLine());



            int volume = height * width * lenght;



            Console.WriteLine("So the volume accourding to your given info is: " + volume);



            Console.ReadKey();



        }

    }

}

