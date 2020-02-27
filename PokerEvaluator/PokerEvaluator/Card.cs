using System.Collections.Generic;
using System.Linq;

namespace PokerEvaluator
{
    public class Card
    {
        public string Suit { get; set; } //suit of the card
        public string Value { get; set; } //value of the card
        public string Unicode { get; set; } //unicode string used to display the card
        private readonly List<string> PossibleSuits = new List<string>() //ordered list of suits
        {
            "Spade",
            "Heart",
            "Diamond",
            "Club"
        };
        private readonly List<string> PossibleValues = new List<string>() //ordered list of values
        {
            "1","2","3","4","5","6","7","8","9","10","11","12","13"
        };
        private readonly List<string> PossibleUnicode = new List<string>() //ordered list of unicode
        {
            "\U0001F0A1","\U0001F0A2","\U0001F0A3","\U0001F0A4","\U0001F0A5","\U0001F0A6","\U0001F0A7","\U0001F0A8","\U0001F0A9","\U0001F0AA","\U0001F0AB","\U0001F0AD","\U0001F0AE",
            "\U0001F0B1","\U0001F0B2","\U0001F0B3","\U0001F0B4","\U0001F0B5","\U0001F0B6","\U0001F0B7","\U0001F0B8","\U0001F0B9","\U0001F0BA","\U0001F0BB","\U0001F0BD","\U0001F0BE",
            "\U0001F0C1","\U0001F0C2","\U0001F0C3","\U0001F0C4","\U0001F0C5","\U0001F0C6","\U0001F0C7","\U0001F0C8","\U0001F0C9","\U0001F0CA","\U0001F0CB","\U0001F0CD","\U0001F0CE",
            "\U0001F0D1","\U0001F0D2","\U0001F0D3","\U0001F0D4","\U0001F0D5","\U0001F0D6","\U0001F0D7","\U0001F0D8","\U0001F0D9","\U0001F0DA","\U0001F0DB","\U0001F0DD","\U0001F0DE"
        };

        public Card(int deckPosition,int suitSelection, int valueSelection)//Sets together all the attricutes of the Cards
        {
            Suit = PossibleSuits.ElementAt(suitSelection); //sets the suit equal to the suit passed in
            Value = PossibleValues.ElementAt(valueSelection); //sets the value equal to the value passed in
            Unicode = PossibleUnicode.ElementAt(deckPosition); //sets the unicode equal to the string corresponding to the ordered deck
        }
    }
}
