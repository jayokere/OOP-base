using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            // Initialise the card pack here
            pack = new List<Card>();
            foreach (var suit in Enum.GetValues(typeof(SuitType)))
            {
                foreach (var value in Enum.GetValues(typeof(ValueType)))
                {
                    pack.Add(new Card((SuitType)suit, (ValueType)value));
                }
            }

        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            // Shuffles the pack based on the type of shuffle
            Random random = new Random();

            switch (typeOfShuffle)
            {
                case 1:
                    // Fisher-Yates Shuffle
                    for (int i = pack.Count - 1; i > 0; i--)
                    {
                        int j = random.Next(i + 1);
                        Card temp = pack[i];
                        pack[i] = pack[j];
                        pack[j] = temp;
                    }
                    return true;
                case 2:
                    // Riffle Shuffle
                    // TODO: Implement Riffle Shuffle

                    List<Card> half1 = pack.Take(pack.Count / 2).ToList();
                    List<Card> half2 = pack.Skip(pack.Count / 2).ToList();

                    List<Card> shuffledPack = new List<Card>();

                    while (half1.Count > 0 && half2.Count > 0)
                    {
                        if (random.NextDouble() < 0.5)
                        {
                            shuffledPack.Add(half1[0]);
                            half1.RemoveAt(0);
                        }
                        else
                        {
                            shuffledPack.Add(half2[0]);
                            half2.RemoveAt(0);
                        }
                    }

                    shuffledPack.AddRange(half1);
                    shuffledPack.AddRange(half2);

                    pack = shuffledPack;

                    return true;

                default:
                    // No Shuffle
                    return false;
            }
        }

        public Card Deal()
        {
            //Deals one card
            Card card = pack[0];
            pack.RemoveAt(0);
            return card;
        }

        public List<Card> DealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                cards.Add(Deal());
            }
            return cards;
        }
    }
}


