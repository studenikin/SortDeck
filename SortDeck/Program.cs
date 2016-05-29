using System;

namespace SortDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Card[] deck = 
            {
                new Card ("Париж", "Берлин"),
                new Card ("Мельбурн", "Кельн"),
                new Card ("Москва", "Париж"),
                new Card ("Кельн", "Москва")
            };

            var sorter = new DeckSorter(deck);
            sorter.Sort();

            OutputDeck(deck);
            Console.Read();
        }

        static void OutputDeck(Card[] deck)
        {
            foreach (var card in deck)
            {
                Console.WriteLine("{0} > {1}", card.From, card.To);
            }
        }
    }
}
