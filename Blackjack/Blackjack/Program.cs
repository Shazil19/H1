using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card[] deck = new Card[52];

            string[] suit = { "Hearts", "Diamonds", "Spades", "Clubs" };
            
            byte deck_counter = 0;

            byte dcounter = 0;

            //the program will start creaking  deck

            for (byte i = 0; i < suit.Length; i++)
            {
                for (byte j = 1; j <= 13 ; j++)
                {
                    deck[deck_counter] = new Card(suit[i],j,j);
                    deck_counter++;
                }
            }

            //shuffling deck

            

            deck = Suffle(deck);

            byte playercounter = 0;

            byte computercounter = 0;

            for (int i = 0; i < 2; i++)
            {

                playercounter += deck[dcounter].Value;

                Console.WriteLine(deck[dcounter].ToString() + "\n");

                dcounter++;

            }

            Console.WriteLine("playercounter:\t" + playercounter + "\n") ;

            for (int i = 0; i < 2; i++)
            {

                computercounter += deck[dcounter].Value;

                Console.WriteLine(deck[dcounter].ToString() + "\n");

                dcounter++;

            }

            Console.WriteLine("computercounter:\t"+computercounter + "\n");

            bool playerturn = true;

            checker(playercounter, computercounter);

            while (playercounter <= 21 && computercounter <= 21)
            {
                if (playerturn == true)
                {

                    Console.WriteLine("want a new card or leave it (Y/N)" + "\n");

                    string replyofuser  = Console.ReadLine();

                    Console.WriteLine("");

                    replyofuser = replyofuser.ToUpper();

                    if (replyofuser == "Y")
                    {
                        playercounter += deck[dcounter].Value;

                        Console.WriteLine(deck[dcounter].ToString() + "\n");

                        dcounter++;

                        Console.WriteLine("playercounter:\t" + playercounter + "\n");

                        checker(playercounter, computercounter);
                    }
                    else if (replyofuser == "N")
                    {
                        playerturn = false;
                    }
                }
                else
                {
                    computercounter += deck[dcounter].Value;

                    Console.WriteLine(deck[dcounter].ToString() + "\n");

                    dcounter++;

                    Console.WriteLine("computercounter:\n" + computercounter + "\n");

                    playerturn = true;

                    checker(playercounter, computercounter);
                }
            }
        }
        public static void checker (byte playercounter , byte computercounter)
        {
            if (playercounter > 21)
            {
                Console.WriteLine("Your total points are over 21");
                Console.WriteLine("\nYou have lost the game.");
                Console.ReadKey();
            }
            else if ( computercounter > 21)
            {
                Console.WriteLine("Computer total points are over 21");
                Console.WriteLine("\nYou have won the game." + "\n");
                Console.ReadKey();
            }
        }
        public static Card[] Suffle(Card[] sorted)
        {
            Random random= new Random();

            for(int i = 0; i < 200; i++)
            {
                // two int(index) to shuffle.

                int index1 = random.Next(0,sorted.Length);
                
                int index2 = random.Next(0,sorted.Length);

                // to save index1 value we put it in placeholder.

                Card placeholder = sorted[index1];

                // changing each other values.

                sorted[index1] = sorted[index2];
                
                sorted[index2] = placeholder;
            }
            return sorted;
        }
    }
}