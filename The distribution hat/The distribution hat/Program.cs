using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_distribution_hat
{
    enum Houses { Gryffindor, Hufflepuff, Ravenclaw, Slytherin }
    class SortingHat
    {
        private static readonly Random random = new Random();
        public Houses AssessStudent()
        {
            int index = random.Next(Enum.GetNames(typeof(Houses)).Length);
            return (Houses)index;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                SortingHat hat = new SortingHat();
                Houses house = hat.AssessStudent();
                Console.WriteLine("You belong to: " + house + "\n");
                Console.ReadKey();

                Console.WriteLine("What a new random one! (Y/N)");

                string Reply = Console.ReadLine();

                Reply = Reply.ToUpper();

                if (Reply == "N")
                {
                    break;
                }
            }
        }
    }
}