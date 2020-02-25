using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEvaluator
{
    public class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }
        private static List<string> PossibleSuits = new List<string>()
        {
            "Club",
            "Spade",
            "Heart",
            "Diamond"
        };
        private static List<string> PossibleValues = new List<string>()
        {
            "Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"
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
