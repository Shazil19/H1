using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos_blancos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] wineSales = { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };
            int maxStar = 100;
            int maxNum = wineSales.Max();

            for (int i = 0; i < wineSales.Length; i++)
            {
                int year = 2009 + i;
                Console.Write("Year " + year + ": ");

                int numOfStars = (int)(maxStar * wineSales[i] / maxNum);

                for (int j = 0; j < numOfStars; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" " + wineSales[i]);
            }

            Console.WriteLine("\nSorting in descending order...\n");
            Array.Sort(wineSales, (a, b) => b.CompareTo(a));

            for (int i = 0; i < wineSales.Length; i++)
            {
                int year = 2009 + i;

                int numOfStars = (int)(maxStar * wineSales[i] / maxNum);

                for (int j = 0; j < numOfStars; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" " + wineSales[i]);
            }
        }
    }
}