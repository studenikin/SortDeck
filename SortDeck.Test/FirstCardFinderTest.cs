using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortDeck.Test
{
    [TestClass]
    public class FirstCardFinderTest
    {
        [TestMethod]
        public void Should_Return_Null_If_Not_Processed()
        {
            var finder = new FirstCardFinder(BuildHashedDeck());

            Assert.IsNull(finder.FirstCard);
        }

        [TestMethod]
        public void Should_Return_Null_If_Card_Is_Not_First_One()
        {
            var finder = new FirstCardFinder(BuildHashedDeck());
            var card = new Card("Berlin", "Oslo");

            finder.Process(card);

            Assert.IsNull(finder.FirstCard);
        }

        [TestMethod]
        public void Should_Return_First_Card()
        {
            var finder = new FirstCardFinder(BuildHashedDeck());
            var card = new Card("Moscow", "Paris");

            finder.Process(card);

            Assert.AreEqual("Moscow", finder.FirstCard.From);
            Assert.AreEqual("Paris", finder.FirstCard.To);
        }

        private Dictionary<string, string> BuildHashedDeck()
        {
            return new Dictionary<string, string>
            {
                {"Berlin", "Oslo" },
                {"Oslo", "Stockholm" },
                {"Moscow", "Paris" },
                {"Paris", "Berlin" }
            };
        }
    }
}
