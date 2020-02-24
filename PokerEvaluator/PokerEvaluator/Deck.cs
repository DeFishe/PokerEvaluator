using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEvaluator
{
    class Deck
    {
        List<Card> cards = new List<Card>();

        public Deck()
        {
            for (int deckPosition = 0; deckPosition < 52; deckPosition++)
            {
                cards.Add(new Card(deckPosition));
            }
        }
    }
}
