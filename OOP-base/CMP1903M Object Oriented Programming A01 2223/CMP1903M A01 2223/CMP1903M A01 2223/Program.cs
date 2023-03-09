using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing.Test();
        }
    }
    class Testing
    {
        public static void Test()
        {
            Pack pack = new Pack();

            // test Fisher-Yates shuffle
            Console.WriteLine("Fisher-Yates Shuffle");

            Console.WriteLine("One Deal:");
            pack.shuffleCardPack(0);
            List<Card> cards0 = pack.DealCard(1);
            foreach (Card card in cards0)
            {
                Console.WriteLine("{0} of {1}", card.Myvalue, card.Mysuit);
            }
            Console.WriteLine();

            Console.WriteLine("Multiple Deals:");
            pack.shuffleCardPack(1);
            List<Card> cards1 = pack.DealCard(5);
            foreach (Card card in cards1)
            {
                Console.WriteLine("{0} of {1}", card.Myvalue, card.Mysuit);
            }
            Console.WriteLine();


            // test Riffle shuffle
            Console.WriteLine("Riffle Shuffle");

            Console.WriteLine("One Deal:");
            pack.shuffleCardPack(2);
            List<Card> cards2 = pack.DealCard(1);
            foreach (Card card in cards2)
            {
                Console.WriteLine("{0} of {1}", card.Myvalue, card.Mysuit);
            }
            Console.WriteLine();

            Console.WriteLine("Multiple Deals:");
            pack.shuffleCardPack(3);
            List<Card> cards3 = pack.DealCard(5);
            foreach (Card card in cards3)
            {
                Console.WriteLine("{0} of {1}", card.Myvalue, card.Mysuit);
            }
            Console.WriteLine();
            // test no shuffle
            Console.WriteLine("No Shuffle");

            pack.shuffleCardPack(5);
            List<Card> cards5 = pack.DealCard(5);
            foreach (Card card in cards5)
            {
                Console.WriteLine("{0} of {1}", card.Myvalue, card.Mysuit);
            }
            Console.WriteLine();
        }
    }
}

