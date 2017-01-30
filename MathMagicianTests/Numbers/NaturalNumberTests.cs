using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        //This a sanity check test.
        //Ensures everything is hooked up correctly and
        //that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateNatInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNatNumber()
        {
            //int GetFirst();
            //Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Call the method you're testing) test one method at the time.
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (Check the output from your method.)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureCanGetNextNat()
        {
            //int GetNext(int current);
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act
            int expectedResult = 4;
            int actualResult = naturalNumber.GetNext(3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureGetNatSequence()
        {
            //int[] GetSequence(int how_many);
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actualResult = naturalNumber.GetSequence(10);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsurePrintNatNumbers()
        {
            //string PrintNumbers(int[] how_many);
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act
            string expectedResult = "1 2 3 4 5";
            string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}


