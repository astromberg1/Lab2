using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        Random random = new Random();
        public List<Card> Cards { get; set; }
        //private List<Card> Cards = new List<Card>();
        public int AboveCard { get; set; }

        public Deck()
        {
            this.Cards = new List<Card>();
            init();
            
        }


        public void init()
        {
            string[] suiteArray = { "Diamonds", "Clubs", "Hearts", "Spades" };
            int kortrek = 0;
            foreach (string item in suiteArray)
            {

                for (int j = 0; j < 13; j++)
                {
                    kortrek = kortrek + 1;
                    Cards.Add(new Card(item, j + 1));
                }
            }
            AboveCard = -1;
        }



        public void Shuffle()
        {
            List<Card> shuffledCards = new List<Card>();
            
            while (Cards.Count > 0)
            {
                int index = random.Next((Cards.Count)); 
                shuffledCards.Add(Cards[index]);
                Cards.RemoveAt(index);
            }
            Cards.AddRange(shuffledCards);
            AboveCard = -1;
        }
        
        public Card GetNextCard()
        {
            if (AboveCard < Cards.Count - 1)
                AboveCard = AboveCard + 1;
            else
                AboveCard = 0;

            return Cards[AboveCard];
        }



    }
}
