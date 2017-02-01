using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        //Recursive Definition of Fibonacci
        //F3 = F2 + F1
        //F7 = F6 + F5
        [TestMethod]
        public void EnsureICanCreateFiboInstance()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            Assert.IsNotNull(fibonacciNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstFib()
        {
            //int GetFirst();
            //Arrange (Where you set stuff up)
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            //Act (Call the method you're testing) test one method at the time.
            int expectedResult = 1;
            int actualResult = fibonacciNumber.GetFirst();

            //Assert (Check the output from your method.)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureCanGetNextFib()
        {
            //int GetNext(int current);
            //Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            //Act
            int expectedResult = 8;
            int actualResult = fibonacciNumber.GetNext(6);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureCanGetFibSequence()
        {
            //int[] GetSequence(int how_many);
            //Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            //Act
            int[] expectedResult = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int[] actualResult = fibonacciNumber.GetSequence(9);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureCanPrintFibNumbers()
        {
            //string PrintNumbers(int[] how_many);
            //Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            //Act
            string expectedResult = "1 1 2 3 5 8 13 21 34";
            string actualResult = fibonacciNumber.PrintNumbers(new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34 });

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
