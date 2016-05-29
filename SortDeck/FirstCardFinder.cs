using System.Collections.Generic;

namespace SortDeck
{
    /// <summary>
    /// Finds the first card in the unsorted deck.
    /// </summary>
    public class FirstCardFinder : ICardProcessor
    {
        readonly Dictionary<string, string> _hashedDeck;

        public FirstCardFinder(Dictionary<string, string> hashedDeck)
        {
            _hashedDeck = hashedDeck;
        }

        public Card FirstCard { get; set; }

        public void Process(Card card)
        {
            if (!_hashedDeck.ContainsValue(card.From))
            {
                FirstCard = card;
                return;
            }
        }
    }
}
