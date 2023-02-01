using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please type your weight (In Kg): ");

            double weight = double.Parse(Console.ReadLine());

            Console.Write("PLease type your height (In Meter): ");

            double height = double.Parse(Console.ReadLine());

            double BMI = (weight / (height * height));

            if (BMI < 16)
            {
                Console.WriteLine("Your BMI: " + BMI + " \nBody weight deflict");
            }

            else if (BMI > 16 && BMI <= 24) 
            {
                Console.WriteLine("Your BMI: " + BMI + " \nNormal");
            }

            else if (BMI > 24 && BMI <= 30)
            {
                Console.WriteLine("Your BMI: " + BMI + " \nweight over");
            }

            else if (BMI > 30 && BMI <= 35)
            {
                Console.WriteLine("Your BMI: " + BMI + " \nObesity first degree");
            }

            else if (BMI > 35 && BMI <= 40)
            {
                Console.WriteLine("Your BMI: " + BMI + " \nObesity second degree");
            }

            else if (BMI > 40)
            {
                Console.WriteLine("Your BMI: " + BMI + " \nObesity third degree");
            }
        }
    }
}
