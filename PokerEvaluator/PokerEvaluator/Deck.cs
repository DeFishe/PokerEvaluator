using System;
using System.Collections.Generic;

namespace PokerEvaluator
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            int deckPosition = 0;
            for (int suitPosition = 0; suitPosition < 4; suitPosition++)
            {
                for (int valuePosition = 0; valuePosition < 13; valuePosition++)
                {
                    cards.Add(new Card(deckPosition++,suitPosition,valuePosition));
                }
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
