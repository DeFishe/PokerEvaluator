using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEvaluator
{
    class Hand
    {
        public List<Card> cards = new List<Card>(); //list of cards in hand
        public bool hasPair, hasTwo, hasThree, hasFour, hasFlush, hasStraight, hasFull; //set of bools for hand evaluation
        public Hand(Deck deck, int mod)
        {
            for (int i = 0; i < 5; i++)
            {
                cards.Add(deck.cards[i + mod]); //adds five cards when a hand is constructed
            }
        }
        

    }
}
