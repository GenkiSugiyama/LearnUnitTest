using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;
using FluentAssertions;

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

        // [TestMethod]
        // データドリブンテスト
        // DataRow属性でパラメーターを指定して外から値を渡す
        // その渡された値分テストを回してくれる
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 5, 8)]
        public void AddTest(int x, int y, int expected)
        {
            // Act
            var actual = calculator.Add(x, y);

            // Assert
            // Assert.AreEqual(2, actual);

            // Fluentアサーション
            // テストコードをより事前言語っぽい書き方にしたもの
            actual.Should().Be(expected);
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