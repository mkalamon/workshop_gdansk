using NUnit.Framework;
using System;
using kalkulator;

namespace KalkulatorTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1, 2, 3)]
        [TestCase(-1, -2, -3)]
        //[TestCase(int.MaxValue, int.MaxValue, 2* int.MaxValue)]
        public void AddingOperation(int firstValue, int secondValue, int expectedValue)
        {
            // Arrange
            MathData mathData = new MathData(firstValue, secondValue, "+");

            // Act
            var result = Calculations.Match(mathData);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

 
    }
}
