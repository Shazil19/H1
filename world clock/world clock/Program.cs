using System;
using System.Collections.Generic;
using System.Linq;

namespace WorldClock
{
    class Program
    {
        static void Main(string[] args)
        {

            //The code starts by defining a list of cities where the user's input of cities will be stored. 

            List<string> cities = new List<string>();
            Console.WriteLine("Enter the cities you want to see the time for (separated by a comma):");
            string input = Console.ReadLine();

            //The user is prompted to enter the cities separated by a comma and the input is split by a comma and added to the list.

            cities = input.Split(',').ToList();

            //the code defines several TimeZoneInfo objects for different cities
            //and retrieves their time zone information using the FindSystemTimeZoneById method.

            TimeZoneInfo lahore         = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            TimeZoneInfo paris          = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");
            TimeZoneInfo london         = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            TimeZoneInfo newYork        = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            TimeZoneInfo perth          = TimeZoneInfo.FindSystemTimeZoneById("W. Australia Standard Time");
            TimeZoneInfo santiago       = TimeZoneInfo.FindSystemTimeZoneById("Central America Standard Time");
            TimeZoneInfo saltLakeCity   = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time");
            TimeZoneInfo copenhagen     = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");

            //The code then enters a while loop that will continue to run until the user presses the ESC key.


            while (true)
            {

                //The loop first clears the console and then iterates through the cities list.

                Console.Clear();

                foreach (string city in cities)
                {

                    //For each city, it compares the lowercase version of the city name with predefined city names and displays the corresponding time using 

                    if (city.ToLower() == "lahore")
                        Console.WriteLine($"Lahore: {TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, lahore)}");
                    else if (city.ToLower() == "paris")
                        Console.WriteLine($"Paris: {TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, paris)}");
                    else if (city.ToLower() == "london")
                        Console.WriteLine($"London: {TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, london)}");
                    else if (city.ToLower() == "new york")
                        Console.WriteLine($"New York: {TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, newYork)}");
                    else if (city.ToLower() == "perth")
                        Console.WriteLine($"Perth: {TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, perth)}");
                    else if (city.ToLower() == "santiago")
                        Console.WriteLine($"Santiago: {TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, santiago)}");
                    else if (city.ToLower() == "salt lake city")
                        Console.WriteLine($"Salt Lake City: {TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, saltLakeCity)}");
                    else if (city.ToLower() == "copenhagen")
                        Console.WriteLine($"Copenhagen: {TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, copenhagen)}");

                    //If the user's input does not match any of the predefined city names, the code will display a message indicating that either the city name is not in the list or there is a spelling mistake.

                    else Console.WriteLine(city + "\t---\tSorry, either the city name you typed is not in the list or there is a spelling mistake.");
                }
                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }

                //The loop then waits for 1 second using the Thread.Sleep method repeats itself to show the most recent time.

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
