using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public int CardValue { get; set; }
        public string Suit { get; set; }
        private string CardName;

        public string cardName
        {
            get {
                return Suit +" " +  CardValue; }
            set { CardName = value; }
        }

        public Card()
        {

        }
        public Card( string suit, int cardValue)
        {
            CardValue = cardValue;
            Suit = suit;
        }
    }
}
