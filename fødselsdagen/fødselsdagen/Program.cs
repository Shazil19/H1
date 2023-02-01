using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace fødselsdagen

{

    internal class Program

    {

        static void Main(string[] args)

        {



            Console.WriteLine("Enter your birthday (ddMMyyyy):");

            string readin = Console.ReadLine();

            DateTime birthday = DateTime.ParseExact(readin, "ddMMyyyy", null);



            DateTime now = DateTime.Now;

            TimeSpan difference = now - birthday;



            int years = (int)Math.Floor(difference.TotalDays / 365.2425);

            birthday = birthday.AddYears(years);

            difference = now - birthday;

            int days = (int)Math.Floor(difference.TotalDays);



            Console.WriteLine("You are " + years + " years and " + days + " days old");



        }

    }

}
