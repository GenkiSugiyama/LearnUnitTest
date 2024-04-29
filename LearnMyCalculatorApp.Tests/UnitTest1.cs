using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // Arrange
        Calculator calculator = new Calculator();

        [TestMethod]
        public void CalculatorNullTest()
        {
            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void AddTest()
        {
            // Act
            var actual = calculator.Add(1, 1);

            // Assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void SubtractTest()
        {
            var actual = calculator.Subtract(5, 1);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            var actual = calculator.Multiply(2, 2);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void DivideTest()
        {
            var actual = calculator.Divide(10, 5);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void DevideByZeroTest()
        {
            var actual = calculator.Divide(1, 0);
            Assert.IsNull(actual);
        }
    }
}