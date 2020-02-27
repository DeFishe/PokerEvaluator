namespace PokerEvaluator
{
    class Dealer
    {
        public Deck deck = new Deck(); //creates a new deck

        //creates 2 hands for players
        public Hand P1Hand;
        public Hand P2Hand;

        public Dealer()
        {
            P1Hand = new Hand(deck, 0); //sets up the two hands, makes sure they have different cards
            P2Hand = new Hand(deck, 5);
        }

        public bool Evaluate() //evaluates the two hands, true if p1 wins, false if p2 wins
        {
            int h1p = 0, h2p = 0, matches = 0, suitMatch = 0, straightMatch = 0;

            foreach (Card item in P1Hand.cards) //for each card in player 1's hand, go through the following checks
            {
                suitMatch = 0; 
                matches = 0;
                foreach (Card check in P1Hand.cards) //goes through all cards in the hand
                {
                    if (item.Value == check.Value) //checks if the two cards match, will occur once since card[i] = card[i]
                    {
                        matches++;
                    }
                    if (item.Suit == check.Suit) //checks if the two cards have same suit
                    {
                        suitMatch++;
                    }
                    if (int.Parse(item.Value) == (int.Parse(check.Value)-1)) //checks if the card is one more than the card
                    {
                        straightMatch++;
                    }
                }
                if (suitMatch == 5) //if the suit matched on all five cards, player must have a flush
                {
                    P1Hand.hasFlush = true;
                }
                if (matches == 2) //if two cards matched, player must have a pair
                {
                    if (P1Hand.hasPair) //if player had a pair, and has another, they have two pairs
                    {
                        P1Hand.hasTwo = true;
                    }
                    P1Hand.hasPair = true;
                }
                else if (matches == 3) //if three cards matches, player must have 3 of a kind
                {
                    P1Hand.hasThree = true;
                }
                else if (matches == 4) //if four cards matches, player must have 4 of a kind
                {
                    P1Hand.hasFour = true;
                }
            }
            if (straightMatch == 4) //if five cards were sequential, then the player must have a straight // Note matches are 4 because the top card does not wrap to the bottom
            {
                P1Hand.hasStraight = true;
            }
            straightMatch = 0;
            foreach (Card item in P2Hand.cards) //repeats above process, see cooresponding comments for player 1s hand
            {
                suitMatch = 0;
                matches = 0;
                foreach (Card check in P2Hand.cards)
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

            //if the hand is a three of a kind and a pair, it is a full house
            if(P1Hand.hasPair && P1Hand.hasThree)
            {
                P1Hand.hasFull = true;
            }
            if (P2Hand.hasPair && P2Hand.hasThree)
            {
                P2Hand.hasFull = true;
            }

            //assigns point values to the best hand the player has
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

            if(h1p == h2p) //tiebreaker if neccessary
            {
                int h1min = 0, h2min = 0;
                foreach(Card item in P1Hand.cards) //finds highest card of player 1
                {
                    if (int.Parse(item.Value) > h1min)
                    {
                        h1min = int.Parse(item.Value);
                    }
                }
                foreach (Card item in P2Hand.cards) //finds highest card of player 2
                {
                    if (int.Parse(item.Value) > h2min)
                    {
                        h2min = int.Parse(item.Value);
                    }
                }
                if (h1min > h2min) //if player 1 has a higher card, they win, otherwise player 2 wins as no further tiebreakers can be done
                {
                    h1p++;
                }
            }

            if (h1p > h2p) //returns as described in header
                return (true);
            else
                return (false);
        }
    }
}
