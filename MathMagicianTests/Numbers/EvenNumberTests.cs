using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }
        [TestMethod]
        public void EnsureTwoIsFirst()
        {
            //int GetFirst();
            //Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (Call the method you're testing) test one method at the time.
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            //Assert (Check the output from your method.)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureCanGetNext()
        {
            //int GetNext(int current);
            //Arrange
            EvenNumber evenNumber = new EvenNumber();

            //Act
            int expectedResult = 4;
            int actualResult = evenNumber.GetNext(2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureCanGetSequence()
        {
            //int[] GetSequence(int how_many);
            //Arrange
            EvenNumber evenNumber = new EvenNumber();

            //Act
            int[] expectedResult = { 2, 4, 6, 8, 10, 12, 14 };
            int[] actualResult = evenNumber.GetSequence(7);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureCanPrintNumbers()
        {
            //string PrintNumbers(int[] how_many);
            //Arrange
            EvenNumber evenNumber = new EvenNumber();

            //Act
            string expectedResult = "2 4 6 8 10 12 14";
            string actualResult = evenNumber.PrintNumbers(new[] { 2, 4, 6, 8, 10, 12, 14 });

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
