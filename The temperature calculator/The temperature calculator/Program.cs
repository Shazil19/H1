using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace The_temperature_calculator

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.Write("Please tell me the temperature:  ");



            double celcius = double.Parse(Console.ReadLine());



            Console.WriteLine("So the temperature is \nCelcius = " + celcius + " °C ");



            double fahrenheit = (celcius * 1.8) + 32;



            Console.WriteLine("Fahrenheit = " + fahrenheit + " °F ");



            double reamus = celcius * 0.8;



            Console.WriteLine("Reamus = " + reamus + " °R ");



            Console.ReadKey();



        }

    }

}

