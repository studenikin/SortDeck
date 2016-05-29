using System.Collections.Generic;

namespace SortDeck
{
    /// <summary>
    /// Generates hash table based on the unsorted deck to improve the algorithm speed.
    /// </summary>
    public class HashedDeckGenerator : ICardProcessor
    {
        readonly Dictionary<string, string> _hashedDeck;

        public HashedDeckGenerator()
        {
            _hashedDeck = new Dictionary<string, string>();
        }

        public Dictionary<string, string> HashedDeck
        {
            get { return _hashedDeck; }
        }

        public void Process(Card card)
        {
            _hashedDeck.Add(card.From, card.To);
        }
    }
}
