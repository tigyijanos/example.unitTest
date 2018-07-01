namespace Tests.MSTest.Service
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using MySoftware.Service;

    /// <summary>
    /// This class tests MathService using MSTest Assert
    /// </summary>
    [TestClass]
    public class MathServiceTests
    {
        private static MathService _service;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _service = new MathService();
        }

        [TestMethod]
        public void SumInt()
        {
            // --- Arrange
            var numberA = 5;
            var numberB = 10;
            var expectedResult = 15;

            // --- Act
            var result = _service.Sum(numberA, numberB);

            // --- Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void SumDouble()
        {
            // --- Arrange
            var numberA = 5.00;
            var numberB = 10.00;
            var expectedResult = 15.00;

            // --- Act
            var result = _service.Sum(numberA, numberB);

            // --- Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void DivideInt()
        {
            // --- Arrange
            var numberA = 10;
            var numberB = 2;
            var expectedResult = 5;

            // --- Act
            var result = _service.Divide(numberA, numberB);

            // --- Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void DivideDouble()
        {
            // --- Arrange
            var numberA = 10.00;
            var numberB = 2.00;
            var expectedResult = 5.00;

            // --- Act
            var result = _service.Divide(numberA, numberB);

            // --- Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZero()
        {
            // --- Arrange
            var numberA = 10;
            var numberB = 0;

            // --- Act
            _service.Divide(numberA, numberB);
        }
    }
}