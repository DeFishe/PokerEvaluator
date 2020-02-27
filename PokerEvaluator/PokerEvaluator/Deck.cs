using System;
using System.Collections.Generic;

namespace PokerEvaluator
{
    public class Deck
    {
        public List<Card> cards = new List<Card>(); //list of card in deck

        public Deck()
        {
            int deckPosition = 0; //starts at index 0 of the deck
            for (int suitPosition = 0; suitPosition < 4; suitPosition++) //starts at index 0 ofo suit, goes to index 3
            {
                for (int valuePosition = 0; valuePosition < 13; valuePosition++) //starts at index 0 of value, goes to 13
                {
                    cards.Add(new Card(deckPosition++,suitPosition,valuePosition)); //adds card to the deck at position dP with suit sP and value vP
                }
            }
            ShuffleDeck(); //shuffles the newly constructed deck
        }

        private void ShuffleDeck() //shuffles the deck procedurally
        {
            Random rand = new Random(); 
            Card cardHolder;
            int randomIndex;
            for (int i = 0; i < cards.Count; i++) //goes through ever card and swaps it with another card
            {
                randomIndex = rand.Next(0, cards.Count - 1);
                cardHolder = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = cardHolder;
            }
        }
    }
}
