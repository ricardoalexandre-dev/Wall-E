using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WallEGarbageCollector
{
    [TestClass]
    public class WallEGarbageCollectorTests
    {
        [TestMethod]
        public void TestCaseForOneMove()
        {
            // arrange
            var input = "N";

            // act
            var actual = WallEGarbageCollector.CollectGarbage(input);
            var expected = "Collected: 2";

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCaseForFourDifferentMoves()
        {
            // arrange
            var input = "NESO";

            // act
            var actual = WallEGarbageCollector.CollectGarbage(input);
            var expected = "Collected: 4";

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCaseForSameMoves()
        {
            // arrange
            var input = "NSNSNS";

            // act
            var actual = WallEGarbageCollector.CollectGarbage(input);
            var expected = "Collected: 2";

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
