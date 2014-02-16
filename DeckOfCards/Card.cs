using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public enum Suit
    {
        Hearts, Diamonds, Spades, Clubs
    }

    public enum FaceValue
    {
        Ace, Two, Three, 
        Four, Five, Six, 
        Seven, Eight, Nine, 
        Ten, Jack, Queen, 
        King
    }

    class Card
    {
        public Card(Suit newSuit, FaceValue newValue)
        {
            m_suit = newSuit;
            m_faceValue = newValue;
        }

        private Suit m_suit;
        public Suit Suit
        {
            get { return m_suit; }
            set { m_suit = value; }
        }

        private FaceValue m_faceValue;
        public FaceValue FaceValue
        {
            get { return m_faceValue; }
            set { m_faceValue = value; }
        }
    }
}
