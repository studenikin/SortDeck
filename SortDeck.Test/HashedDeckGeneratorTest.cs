using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortDeck.Test
{
    [TestClass]
    public class HashedDeckGeneratorTest
    {
        [TestMethod]
        public void Should_Initialize_Empty_Dictionary()
        {
            var hd = new HashedDeckGenerator();

            Assert.AreEqual(0, hd.HashedDeck.Count);
        }

        [TestMethod]
        public void Should_Add_Card_To_Dictionary_On_Process()
        {
            var hd = new HashedDeckGenerator();
            var card = new Card("Moscow", "Paris");

            hd.Process(card);

            Assert.AreEqual(1, hd.HashedDeck.Count);
        }

        [TestMethod]
        public void Should_Have_Correct_Value_When_Card_Added()
        {
            var hd = new HashedDeckGenerator();
            var card = new Card("Moscow", "Paris");

            hd.Process(card);

            Assert.AreEqual("Paris", hd.HashedDeck["Moscow"]);
        }
    }
}
