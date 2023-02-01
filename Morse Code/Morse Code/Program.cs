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

                        output += ".- ";

                        break;

                    case 'b':

                        output += "-... ";

                        break;

                    case 'c':

                        output += "-.-. ";

                        break;

                    case 'd':

                        output += "-.. ";

                        break;

                    case 'e':

                        output += ". ";

                        break;

                    case 'f':

                        output += "..-. ";

                        break;

                    case 'g':

                        output += "--. ";

                        break;

                    case 'h':

                        output += ".... ";

                        break;

                    case 'i':

                        output += ".. ";

                        break;

                    case 'j':

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

