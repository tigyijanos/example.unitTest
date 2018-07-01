// ReSharper disable once StyleCop.SA1200
using NUnit.Framework;

namespace Tests.NUnit.Service
{
    using System;

    using MySoftware.Service;

    /// <summary>
    /// This class tests MathService using NUnit Assert
    /// </summary>
    [TestFixture]
    public class MathServiceTests
    {
        private static MathService _service;

        [SetUp]
        public void ClassInitialize()
        {
            _service = new MathService();
        }

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
        public void DivideByZero()
        {
            // --- Arrange
            var numberA = 10;
            var numberB = 0;

            // --- Act
            var result = Assert.Throws<DivideByZeroException>(() => { _service.Divide(numberA, numberB); });

            // --- Assert
            Assert.That(result != null);
            Assert.That(result.Message == "You can't do that!");
        }
    }
}