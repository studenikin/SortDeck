namespace SortDeck
{
    /// <summary>
    /// Encapsulates trip card (e.g. "from" -> "to").
    /// </summary>
    public class Card
    {
        public string From { get; set; }
        public string To { get; set; }

        public Card() { }

        public Card(string from, string to)
        {
            From = from;
            To = to;
        }
    }
}
