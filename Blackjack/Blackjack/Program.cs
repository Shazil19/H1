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

            while (true)
            {

                int yourfirstcard = 0;
                int yoursecondcard = 0;
                int computerfirstcard = 0;

                for (int i = 0; i < 3;i++)
                {
                    if (i == 0) { Console.WriteLine("this is your first card: " + deck[i].ToString()); yourfirstcard = int.Parse(deck[i].ToString()); }
                    else if (i == 1) { Console.WriteLine("This is your second card: " + deck[i].ToString()); yoursecondcard = int.Parse(deck[i].ToString()); }
                    else if (i == 2) { Console.WriteLine("this is my first card: " + deck[i].ToString()); computerfirstcard = int.Parse(deck[i].ToString()); }
                }

                Console.WriteLine(yourfirstcard + yoursecondcard + computerfirstcard);

                break;


            }

            Console.WriteLine("done");

            //deck is shuffled

            //Console.WriteLine("Here are your two card: \n" + deck[0].ToString() +"\n"+ deck[1].ToString());

            //Console.WriteLine("here are my card: " + deck[2].ToString());

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
/*
 
the program is done creaking deck

            Console.WriteLine(deck[10].Suit + " : \t" + deck[0].Value);

            Console.WriteLine(deck[0].ToString());


            shuffling deck

            deck = Suffle(deck);

            deck is shuffled

            foreach (Card item in deck)
            {
                Console.WriteLine(item.Suit + " : \t" + item.Value);
            }

            Console.ReadKey();
 
 */