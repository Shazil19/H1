using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Morse_Code

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter text to convert to Morse code:");

            string input = Console.ReadLine();

            string output = "";



            foreach (char c in input)

            {

                switch (c)

                {

                    case 'a':

                        Console.ForegroundColor = ConsoleColor.Red;

                        output += ".- ";

                        break;

                    case 'b':

                        Console.ForegroundColor = ConsoleColor.Green;

                        output += "-... ";

                        break;

                    case 'c':

                        Console.ForegroundColor = ConsoleColor.Yellow;

                        output += "-.-. ";

                        break;

                    case 'd':

                        Console.ForegroundColor = ConsoleColor.Black;

                        output += "-.. ";

                        break;

                    case 'e':

                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        output += ". ";

                        break;

                    case 'f':

                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        output += "..-. ";

                        break;

                    case 'g':

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        output += "--. ";

                        break;

                    case 'h':

                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                        output += ".... ";

                        break;

                    case 'i':

                        Console.ForegroundColor = ConsoleColor.Gray;

                        output += ".. ";

                        break;

                    case 'j':

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        output += ".--- ";

                        break;

                    case 'k':

                        output += "-.- ";

                        break;

                    case 'l':

                        output += ".-.. ";

                        break;

                    case 'm':

                        output += "-- ";

                        break;

                    case 'n':

                        output += "-. ";

                        break;

                    case 'o':

                        output += "--- ";

                        break;

                    case 'p':

                        output += ".--. ";

                        break;

                    case 'q':

                        output += "--.- ";

                        break;

                    case 'r':

                        output += ".-. ";

                        break;

                    case 's':

                        output += "... ";

                        break;

                    case 't':

                        output += "- ";

                        break;

                    case 'u':

                        output += "..- ";

                        break;

                    case 'v':

                        output += "...- ";

                        break;

                    case 'w':

                        output += ".-- ";

                        break;

                    case 'x':

                        output += "-..- ";

                        break;

                    case 'y':

                        output += "-.-- ";

                        break;

                    case 'z':

                        output += "--.. ";

                        break;

                    case 'æ':

                        output += ".-.- ";

                        break;

                    case 'ø':

                        output += "---. ";

                        break;

                    case 'å':

                        output += ".--.- ";

                        break;

                    case '0':

                        output += "----- ";

                        break;

                    case '1':

                        output += ".---- ";

                        break;

                    case '2':

                        output += "..--- ";

                        break;

                    case '3':

                        output += "...-- ";

                        break;

                    case '4':

                        output += "....- ";

                        break;

                    case '5':

                        output += "..... ";

                        break;

                    case '6':

                        output += "-.... ";

                        break;

                    case '7':

                        output += "--... ";

                        break;

                    case '8':

                        output += "---.. ";

                        break;

                    case '9':

                        output += "----. ";

                        break;

                    case '.':

                        output += ".-.-.- ";

                        break;

                    case ',':

                        output += "--..-- ";

                        break;

                    case ':':

                        output += "---... ";

                        break;

                    case '?':

                        output += "..--.. ";

                        break;

                    case '\'':

                        output += ".----. ";

                        break;

                    case '-':

                        output += "-....- ";

                        break;

                    case '/':

                        output += "-..-.. ";

                        break;

                    case '(':

                        output += "-.--. ";

                        break;

                    case ')':

                        output += "-.--.- ";

                        break;

                    case '"':

                        output += ".-..-. ";

                        break;

                    case '*':

                        output += "-..- ";

                        break;

                    case '@':

                        output += ".--.-. ";

                        break;

                    case '\n':

                        output += ".-.- ";

                        break;

                }

            }



            Console.WriteLine(output);



        }

    }

}

