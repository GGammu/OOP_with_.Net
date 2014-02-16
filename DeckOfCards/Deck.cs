using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Deck
    {
        private System.Collections.ArrayList m_cards = new System.Collections.ArrayList();

        public Deck()
        {
            Suit[] suits = { Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades };
            FaceValue[] values = {  FaceValue.Ace, FaceValue.Two, FaceValue.Three, FaceValue.Four, 
                                    FaceValue.Five, FaceValue.Six, FaceValue.Seven, FaceValue.Eight, 
                                    FaceValue.Nine, FaceValue.Ten, FaceValue.Jack, FaceValue.Queen, 
                                    FaceValue.King};

            this.MakeDeck(suits, values);
        }

        public Deck(Suit[] suits, FaceValue[] values)
        {
            this.MakeDeck(suits, values);
        }

        public int Count
        {
            get { return m_cards.Count; }
        }

        public Card this[int indexer]
        {
            get
            {
                if (indexer >= 0 && indexer < m_cards.Count)
                {
                    return (Card)m_cards[indexer];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
            }
        }

        private void MakeDeck(Suit[] suits, FaceValue[] values)
        {
            for (int aSuit = 0; aSuit < suits.Length; aSuit++)
            {
                for (int avalue = 0; avalue < values.Length; avalue++)
                {
                    m_cards.Add(new Card(suits[aSuit], values[avalue]));
                }
            }
        }

        public void Shuffle()
        {
            System.Random rGen = new System.Random();
            System.Collections.ArrayList newDeck = new System.Collections.ArrayList();
            while (m_cards.Count > 0)
            {
                //Choose one card at random to remove.
                int toRemove = rGen.Next(0, m_cards.Count - 1);
                Card remove = (Card)m_cards[toRemove];
                m_cards.Remove(remove);
                //Add the removed card to the new deck.
                newDeck.Add(remove);
            }
            m_cards = newDeck;
        }

        public void Deal(Hand[] hands)
        {
            int handIndex = 0;
            while (m_cards.Count > 0)
            {
                hands[handIndex].Add((Card)m_cards[0]);
                m_cards.RemoveAt(0);
                handIndex = (handIndex == hands.Length - 1 ? 0 : handIndex + 1);
            }
        }

        public Card Draw()
        {
            Card topCard = null;
            if (m_cards.Count > 0)
            {
                topCard = (Card)m_cards[0];
                m_cards.RemoveAt(0);
            }
            return topCard;
        }
    }
}
