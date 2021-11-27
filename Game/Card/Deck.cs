using System;
using System.Collections.Generic;
using System.Linq;
using Uaine.Objects.Primitives.Values;

namespace Uaine.Objects.Game.Card
{
    public class Deck
    {
        protected IValue numCards;
        public int RemainingCards { get => numCards.Value; }
        public int DeckSize { get => numCards.def; }
        protected Card[] cardDeck;
        protected List<Card> discardPile;
        public int NumberDiscardCards { get => discardPile.Count; }

        public Deck(int numValues, int numClasses)
        {
            numCards = numValues * numClasses;
            cardDeck = new Card[numCards.Value];
            discardPile = new List<Card>();
            int k = 0;
            for (int i = 0; i < numValues; i++)
            {
                for (int c = 0; c < numClasses; c++)
                {
                    cardDeck[k] = new Card(i, c);
                    k += 1;
                }
            }
            ShuffleDeck();
        }

        public void ShuffleDeck()
        {
            System.Random random = new System.Random();
            cardDeck = cardDeck.OrderBy(x => random.Next()).ToArray();
        }
    }
}
