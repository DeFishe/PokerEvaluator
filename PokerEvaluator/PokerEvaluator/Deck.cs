using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //ShuffleDeck();
        }

        private void ShuffleDeck()
        {
            throw new NotImplementedException();
        }
    }
}
