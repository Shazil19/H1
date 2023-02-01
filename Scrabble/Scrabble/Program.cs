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
            Console.Write("Enter a word: \t");
            string word = Console.ReadLine();

            int wordPoints = CalculateScabble(word.ToUpper());

            Console.WriteLine("Word Points: " + wordPoints);
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