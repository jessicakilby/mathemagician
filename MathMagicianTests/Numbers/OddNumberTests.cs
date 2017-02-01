using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateOddInstance()
        {
            OddNumber oddNumber = new OddNumber();

            Assert.IsNotNull(oddNumber);
        }
        [TestMethod]
        public void EnsureOneIsFirstOdd()
        {
            //int GetFirst();
            //Arrange (Where you set stuff up)
            OddNumber oddNumber = new OddNumber();

            //Act (Call the method you're testing) test one method at the time.
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            //Assert (Check the output from your method.)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureCanGetNextOdd()
        {
            //int GetNext(int current);
            //Arrange
            OddNumber oddNumber = new OddNumber();

            //Act
            int expectedResult = 3;
            int actualResult = oddNumber.GetNext(1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureCanGetOddSequence()
        {
            //int[] GetSequence(int how_many);
            //Arrange
            OddNumber oddNumber = new OddNumber();

            //Act
            int[] expectedResult = { 1, 3, 5, 7, 9, 11, 13 };
            int[] actualResult = oddNumber.GetSequence(7);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureCanPrintOddNumbers()
        {
            //string PrintNumbers(int[] how_many);
            //Arrange
            OddNumber oddNumber = new OddNumber();

            //Act
            string expectedResult = "1 3 5 7 9 11 13";
            string actualResult = oddNumber.PrintNumbers(new[] { 1, 3, 5, 7, 9, 11, 13 });

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
