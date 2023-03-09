using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

    //Value: numbers 1 - 13
    public enum ValueType
    {
        TWO = 2, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
    }
    //Suit: numbers 1 - 4
    public enum SuitType
    {
        HEARTS,
        SPADES,
        DIAMONDS,
        CLUBS
    }

    class Card
    {
        //Base for the Card class.

        //The 'set' methods for these properties could have some validation
        public SuitType Mysuit { get; set; }
        public ValueType Myvalue { get; set; }

        public Card(SuitType suit, ValueType value)
        {
            Mysuit = suit;
            Myvalue = value;
        }
    }
}
