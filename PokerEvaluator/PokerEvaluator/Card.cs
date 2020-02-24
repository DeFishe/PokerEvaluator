using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEvaluator
{
    class Card
    {
        string Suit { get; set; }
        string Value { get; set; }
        private static List<string> PossibleSuits = new List<string>()
        {
            "Club",
            "Spade",
            "Heart",
            "Diamond"
        };
        private static List<string> PossibleValues = new List<string>()
        {
            "1","2","3","4","5","6","7","8","10","Jack","Queen","King"
        };

        public Card(int deckPosition)
        {
            int suitSelection = deckPosition % 4;
            int valueSelection = deckPosition % 13;
            Suit = PossibleSuits.ElementAt(suitSelection);
            Value = PossibleValues.ElementAt(valueSelection);
        }
    }
}
