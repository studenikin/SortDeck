using System;
using System.Collections.Generic;

namespace SortDeck
{
    /// <summary>
    /// Gets unsorted deck and returns the sorted one.
    /// </summary>
    public class DeckSorter
    {
        readonly Card[] _unsortedDeck;

        public DeckSorter(Card[] unsortedDeck)
        {
            ValidateDeck(unsortedDeck);
            _unsortedDeck = unsortedDeck;
        }

        public void Sort()
        {
            var hashGen = new HashedDeckGenerator();
            ProcessDeck(hashGen);

            var firstCardFinder = new FirstCardFinder(hashGen.HashedDeck);
            ProcessDeck(firstCardFinder);

            Sort(firstCardFinder.FirstCard, hashGen.HashedDeck);
        }

        private void ValidateDeck(Card[] deck)
        {
            if (deck == null || deck.Length == 0)
            {
                throw new ArgumentException();
            }
        }

        private void Sort(Card firstCard, Dictionary<string, string> hashedDeck)
        {
            _unsortedDeck[0] = firstCard;

            int i = 1;
            while (i < hashedDeck.Count)
            {
                var card = new Card
                {
                    From = _unsortedDeck[i - 1].To,
                    To = hashedDeck[_unsortedDeck[i - 1].To]
                };
                _unsortedDeck[i] = card;
                i += 1;
            }
        }

        private void ProcessDeck(ICardProcessor processor)
        {
            for (int i = 0; i < _unsortedDeck.Length; i++)
            {
                processor.Process(_unsortedDeck[i]);
            }
        }
    }
}
