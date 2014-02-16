using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Hand
    {
        private System.Collections.ArrayList m_cards = new System.Collections.ArrayList();

        public Hand()
        {
        }

        public Hand(Card[] cards) 
        {
            m_cards.AddRange(cards);
        }

        public int Count
        {
            get { return m_cards.Count; }
        }

        public Card this[int indexer]
        {
            get { return (Card)m_cards[indexer]; }
        }

        public void Add(Card newCard)
        {
            m_cards.Add(newCard);
        }

        public bool Contains(Card cardToFind)
        {
            return m_cards.Contains(cardToFind);
        }

        public bool Contains(Suit suitToFind, FaceValue valueToFind)
        {
            bool found = false;
            Card aCard;
            for (int i = 0; i < m_cards.Count; i++)
            {
                aCard = (Card)m_cards[i];
                if ((aCard.Suit == suitToFind) && (aCard.FaceValue == valueToFind))
                {
                    found = true;
                }
            }
            return found;
        }

        public void Remove(Suit suitToFind, FaceValue valueToFind)
        {
            Card aCard;
            for (int i = 0; i < m_cards.Count; i++)
            {
                aCard = (Card)m_cards[i];
                if ((aCard.Suit == suitToFind) && (aCard.FaceValue == valueToFind))
                {
                    m_cards.Remove(aCard);
                    break;
                }
            }
        }

        public void Remove(Card cardToFind)
        {
            if (m_cards.Contains(cardToFind))
            {
                m_cards.Remove(cardToFind);
            }
        }

        public void RemovePairs()
        {
            Card findMatch, possibleMatch = null;
            bool found;
            System.Collections.ArrayList noMatches = new System.Collections.ArrayList();
            while (m_cards.Count > 0)
            {
                findMatch = (Card)m_cards[0];
                found = false;
                for (int i = 1; i < m_cards.Count; i++)
                {
                    possibleMatch = (Card)m_cards[i];
                    if (possibleMatch.FaceValue == findMatch.FaceValue)
                    {
                        found = true;
                        m_cards.Remove(findMatch);
                        m_cards.Remove(possibleMatch);
                        break;
                    }
                }
                if (!found)
                {
                    noMatches.Add(findMatch);
                    m_cards.Remove(findMatch);
                }
            }
            m_cards = noMatches;
        }

        //public static void Main()
        //{
        //    Card queenOfHearts = new Card(Suit.Hearts, FaceValue.Queen);
        //    Card twoOfClubs = new Card(Suit.Clubs, FaceValue.Two);

        //    //Test: Add(Card[])
        //    Hand aHand = new Hand(new Card[] { queenOfHearts, twoOfClubs });

        //    //Test: Contains(Card)  Expect: True
        //    Console.WriteLine("Hand contains queenOfHearts: {0}.", aHand.Contains(queenOfHearts));

        //    //Test: Contains(Suit, Value)  Expect: True
        //    Console.WriteLine("Hand contains queenOfHearts: {0}.", aHand.Contains(Suit.Hearts, FaceValue.Queen));

        //    //Test: Remove(Card)
        //    aHand.Remove(queenOfHearts);

        //    //Test: Contains(Card)  Expect: False
        //    Console.WriteLine("Hand contains queenOfHearts: {0}.", aHand.Contains(Suit.Hearts, FaceValue.Queen));

        //    //Test: Contains(Card)  Expect: False
        //    Console.WriteLine("Hand contains queenOfHearts: {0}.", aHand.Contains(queenOfHearts));

        //    Hand pair = new Hand();
            
        //    //Test: Add(Suit, Value);
        //    pair.Add(new Card(Suit.Diamonds, FaceValue.Ace));
        //    pair.Add(new Card(Suit.Clubs, FaceValue.Ace));

        //    //Test: Count Expect: 2 Cards
        //    Console.WriteLine("Pair has {0} cards.", pair.Count);
            
        //    pair.RemovePairs();

        //    //Test: Remove Pairs Expect: 0 Cards
        //    Console.WriteLine("After RemovePairs, Pair has {0} cards.", pair.Count);

        //    Console.ReadLine();
        //}
    }
}
