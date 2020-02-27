using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEvaluator
{
    class Dealer
    {
        public static Deck deck = new Deck();
        public Hand P1Hand = new Hand(deck, 0);
        public Hand P2Hand = new Hand(deck, 5);


        public Dealer()
        {
        }

        public bool Evaluate()
        {
            int h1p = 0, h2p = 0, matches = 0, suitMatch = 0, straightMatch = 0;

            foreach (Card item in P1Hand.cards)
            {
                suitMatch = 0;
                matches = 0;
                foreach (Card check in P1Hand.cards)
                {
                    if (item.Value == check.Value)
                    {
                        matches++;
                    }
                    if (item.Suit == check.Suit)
                    {
                        suitMatch++;
                    }
                    if (int.Parse(item.Value) == (int.Parse(check.Value)-1))
                    {
                        straightMatch++;
                    }
                }
                if (suitMatch == 5)
                {
                    P1Hand.hasFlush = true;
                }
                if (matches == 2)
                {
                    if (P1Hand.hasPair)
                    {
                        P1Hand.hasTwo = true;
                    }
                    P1Hand.hasPair = true;
                }
                else if (matches == 3)
                {
                    P1Hand.hasThree = true;
                }
                else if (matches == 4)
                {
                    P1Hand.hasFour = true;
                }
            }
            if (straightMatch == 4)
            {
                P1Hand.hasStraight = true;
            }
            straightMatch = 0;
            foreach (Card item in P1Hand.cards)
            {
                suitMatch = 0;
                matches = 0;
                foreach (Card check in P1Hand.cards)
                {
                    if (item.Value == check.Value)
                    {
                        matches++;
                    }
                    if (item.Suit == check.Suit)
                    {
                        suitMatch++;
                    }
                    if (int.Parse(item.Value) == (int.Parse(check.Value) - 1))
                    {
                        straightMatch++;
                    }
                }
                if (suitMatch == 5)
                {
                    P2Hand.hasFlush = true;
                }
                if (matches == 2)
                {
                    if(P2Hand.hasPair)
                    {
                        P2Hand.hasTwo = true;
                    }
                    P2Hand.hasPair = true;
                }
                else if (matches == 3)
                {
                    P2Hand.hasThree = true;
                }
                else if (matches == 4)
                {
                    P2Hand.hasFour = true;
                }
            }
            if (straightMatch == 4)
            {
                P2Hand.hasStraight = true;
            }

            if(P1Hand.hasPair && P1Hand.hasThree)
            {
                P1Hand.hasFull = true;
            }
            if (P2Hand.hasPair && P2Hand.hasThree)
            {
                P2Hand.hasFull = true;
            }

            if(P1Hand.hasPair)
            {
                h1p = 1;
            }
            if(P1Hand.hasTwo)
            {
                h1p = 2;
            }
            if(P1Hand.hasThree)
            {
                h1p = 3;
            }
            if(P2Hand.hasFour)
            {
                h1p = 4;
            }
            if(P1Hand.hasFlush)
            {
                h1p = 5;
            }
            if(P1Hand.hasStraight)
            {
                h1p = 6;
            }
            if(P1Hand.hasFull)
            {
                h1p = 7;
            }

            if (P2Hand.hasPair)
            {
                h2p = 1;
            }
            if (P2Hand.hasTwo)
            {
                h2p = 2;
            }
            if (P2Hand.hasThree)
            {
                h2p = 3;
            }
            if (P2Hand.hasFour)
            {
                h2p = 4;
            }
            if (P2Hand.hasFlush)
            {
                h2p = 5;
            }
            if (P2Hand.hasStraight)
            {
                h2p = 6;
            }
            if (P2Hand.hasFull)
            {
                h2p = 7;
            }

            if(h1p == h2p)
            {
                int h1min = 0, h2min = 0;
                foreach(Card item in P1Hand.cards)
                {
                    if (int.Parse(item.Value) > h1min)
                    {
                        h1min = int.Parse(item.Value);
                    }
                }
                foreach (Card item in P2Hand.cards)
                {
                    if (int.Parse(item.Value) > h2min)
                    {
                        h2min = int.Parse(item.Value);
                    }
                }
                if (h1min > h2min)
                {
                    h1p++;
                }
            }

            if (h1p > h2p)
                return (true);
            else
                return (false);
        }
    }
}
