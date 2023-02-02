using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool reply = true;

            while (reply)

            {

                Console.Write("\nEnter a word: \t");

                string word = Console.ReadLine();

                int wordPoints = CalculateScabble(word.ToUpper());

                Console.WriteLine("\nWord Points: " + wordPoints + "\n");

                Console.WriteLine("Do you want to play again (Y: Yes & N: No) : \n");

                string UserReply = Console.ReadLine();

                UserReply = UserReply.ToUpper();

                if (UserReply == "Y")
                {
                    reply= true;
                }

                else if (UserReply == "N")
                {
                    reply= false;
                }

                else { reply= false; }

            }

            Console.WriteLine("\nThanks for playing\n");

            Console.ReadKey();
        }

        public static int CalculateScabble(string word)
        {
            int wordPoints = 0;

            foreach (char letter in word)
            {
                switch (letter)
                {
                    case 'E':
                    case 'A':
                    case 'N':
                    case 'R':
                        wordPoints += 1;
                        break;
                    case 'D':
                    case 'L':
                    case 'O':
                    case 'S':
                    case 'T':
                        wordPoints += 2;
                        break;
                    case 'B':
                    case 'I':
                    case 'K':
                    case 'F':
                    case 'G':
                    case 'M':
                    case 'U':
                    case 'V':
                        wordPoints += 3;
                        break;
                    case 'H':
                    case 'J':
                    case 'P':
                    case 'Y':
                    case 'Æ':
                    case 'Ø':
                    case 'Å':
                        wordPoints += 4;
                        break;
                    case 'C':
                    case 'X':
                    case 'Z':
                    case 'W':
                    case 'Q':
                        wordPoints += 8;
                        break;
                }
            }

            return wordPoints;
        }
    }
}