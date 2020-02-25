using System;
using System.Collections.Generic;

namespace PokerEvaluator
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            for (int deckPosition = 0; deckPosition < 52; deckPosition++)
            {
                cards.Add(new Card(deckPosition));
            }
            ShuffleDeck();
        }

        private void ShuffleDeck()
        {
            Random rand = new Random();
            Card cardHolder;
            int randomIndex;
            for (int i = 0; i < cards.Count; i++)
            {
                randomIndex = rand.Next(0, cards.Count - 1);
                cardHolder = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = cardHolder;
            }
        }
    }
}
