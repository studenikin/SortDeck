namespace SortDeck
{
    /// <summary>
    /// Implements visitor pattern for processing each card while iterating the deck.
    /// </summary>
    public interface ICardProcessor
    {
        void Process(Card card);
    }
}
