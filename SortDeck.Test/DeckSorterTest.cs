using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortDeck.Test
{
    [TestClass]
    public class DeckSorterTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_If_Deck_Is_Null()
        {
            var sorter = new DeckSorter(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_If_Deck_Is_Empty()
        {
            Card[] deck = { };
            var sorter = new DeckSorter(deck);
        }

        [TestMethod]
        public void Should_Return_Same_Card_If_Only_One_In_The_Deck()
        {
            Card[] deck = {
                new Card("Moscow", "Paris")
            };

            var sorter = new DeckSorter(deck);
            sorter.Sort();

            Assert.AreEqual("Moscow", deck[0].From);
            Assert.AreEqual("Paris", deck[0].To);
        }

        [TestMethod]
        public void Should_Not_Change_Order_If_Cards_Already_Sorted()
        {
            Card[] deck = {
                new Card("Moscow", "Paris"),
                new Card("Paris", "Berlin")
            };

            var sorter = new DeckSorter(deck);
            sorter.Sort();

            Assert.AreEqual("Moscow", deck[0].From);
            Assert.AreEqual("Paris", deck[0].To);

            Assert.AreEqual("Paris", deck[1].From);
            Assert.AreEqual("Berlin", deck[1].To);
        }

        [TestMethod]
        public void Should_Change_Order_If_Cards_Not_Sorted()
        {
            Card[] deck = {
                new Card("Paris", "Berlin"),
                new Card("Moscow", "Paris"),
                new Card("Oslo", "Moscow")
            };

            var sorter = new DeckSorter(deck);
            sorter.Sort();

            Assert.AreEqual("Oslo", deck[0].From);
            Assert.AreEqual("Moscow", deck[0].To);

            Assert.AreEqual("Moscow", deck[1].From);
            Assert.AreEqual("Paris", deck[1].To);

            Assert.AreEqual("Paris", deck[2].From);
            Assert.AreEqual("Berlin", deck[2].To);
        }
    }
}
