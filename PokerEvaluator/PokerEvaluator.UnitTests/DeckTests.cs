using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PokerEvaluator.UnitTests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void DeckConstructor_DeckMade_IsEqualTo52()
        {
            //arrange
            Deck deck = new Deck();
            var expectedDeckSize = 52;
            int deckSize;
            //act
            deckSize = deck.cards.Count;
            //assert
            Assert.AreEqual(expectedDeckSize, deckSize);
        }
        [TestMethod]
        public void DeckConstructor_ClubsMade_IsEqualTo13()
        {
            //arrange
            var deck = new Deck();
            int clubCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Suit == "Club")
                    clubCount++;
            }
            //assert
            Assert.AreEqual(13, clubCount);
        }
        [TestMethod]
        public void DeckConstructor_SpadesMade_IsEqualTo13()
        {
            //arrange
            var deck = new Deck();
            int spadeCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Suit == "Spade")
                    spadeCount++;
            }
            //assert
            Assert.AreEqual(13, spadeCount);
        }
        [TestMethod]
        public void DeckConstructor_HeartsMade_IsEqualTo13()
        {
            //arrange
            var deck = new Deck();
            int heartCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Suit == "Heart")
                    heartCount++;
            }
            //assert
            Assert.AreEqual(13, heartCount);
        }
        [TestMethod]
        public void DeckConstructor_DiamondsMade_IsEqualTo13()
        {
            //arrange
            var deck = new Deck();
            int diamondCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Suit == "Diamond")
                    diamondCount++;
            }
            //assert
            Assert.AreEqual(13, diamondCount);
        }
        [TestMethod]
        public void DeckConstructor_AcesMade_IsEqualTo13()
        {
            //arrange
            var deck = new Deck();
            int aceCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "Ace")
                    aceCount++;
            }
            //assert
            Assert.AreEqual(4, aceCount);
        }
        [TestMethod]
        public void DeckConstructor_2sMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int twoCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "2")
                    twoCount++;
            }
            //assert
            Assert.AreEqual(4, twoCount);
        }
        [TestMethod]
        public void DeckConstructor_3sMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int threeCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "3")
                    threeCount++;
            }
            //assert
            Assert.AreEqual(4, threeCount);
        }
        [TestMethod]
        public void DeckConstructor_4sMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int fourCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "4")
                    fourCount++;
            }
            //assert
            Assert.AreEqual(4, fourCount);
        }
        [TestMethod]
        public void DeckConstructor_5sMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int fiveCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "5")
                    fiveCount++;
            }
            //assert
            Assert.AreEqual(4, fiveCount);
        }
        [TestMethod]
        public void DeckConstructor_6sMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int sixCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "6")
                    sixCount++;
            }
            //assert
            Assert.AreEqual(4, sixCount);
        }
        [TestMethod]
        public void DeckConstructor_7sMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int sevenCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "7")
                    sevenCount++;
            }
            //assert
            Assert.AreEqual(4, sevenCount);
        }
        [TestMethod]
        public void DeckConstructor_8sMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int eightCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "8")
                    eightCount++;
            }
            //assert
            Assert.AreEqual(4, eightCount);
        }
        [TestMethod]
        public void DeckConstructor_9sMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int nineCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "9")
                    nineCount++;
            }
            //assert
            Assert.AreEqual(4, nineCount);
        }
        [TestMethod]
        public void DeckConstructor_10sMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int tenCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "10")
                    tenCount++;
            }
            //assert
            Assert.AreEqual(4, tenCount);
        }
        [TestMethod]
        public void DeckConstructor_JacksMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int jackCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "Jack")
                    jackCount++;
            }
            //assert
            Assert.AreEqual(4, jackCount);
        }
        [TestMethod]
        public void DeckConstructor_QueensMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int queenCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "Queen")
                    queenCount++;
            }
            //assert
            Assert.AreEqual(4, queenCount);
        }
        [TestMethod]
        public void DeckConstructor_KingsMade_IsEqualTo4()
        {
            //arrange
            var deck = new Deck();
            int kingCount = 0;
            //act
            foreach (Card card in deck.cards)
            {
                if (card.Value == "King")
                    kingCount++;
            }
            //assert
            Assert.AreEqual(4, kingCount);
        }
        [TestMethod]
        public void DeckShuffle_DefaultShuffle_ShuffledCollectionAndUnshuffledCollectionAreNotEqual()
        {
            //arrange
            Deck sortedDeck = new Deck();
            List<Card> unsortedDeck = new List<Card>();
            //act
            for (int deckPosition = 0; deckPosition < 52; deckPosition++)
            {
                unsortedDeck.Add(new Card(deckPosition));
            }
            //assert
            CollectionAssert.AreNotEqual(unsortedDeck, sortedDeck.cards);
        }
    }
}
