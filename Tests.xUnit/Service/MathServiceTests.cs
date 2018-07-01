namespace Tests.xUnit.Service
{
    using System;

    using MySoftware.Service;
    using Xunit;

    /// <summary>
    /// This class tests MathService using Xunit Assert
    /// </summary>
    public class MathServiceTests : IDisposable
    {
        private static MathService _service;

        public MathServiceTests()
        {
            _service = new MathService();
        }

        public void Dispose()
        {
            // Not required, just for demonstration
            _service = null;
        }

        [Fact]
        public void SumInt()
        {
            // --- Arrange
            var numberA = 5;
            var numberB = 10;
            var expectedResult = 15;

            // --- Act
            var result = _service.Sum(numberA, numberB);

            // --- Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void SumDouble()
        {
            // --- Arrange
            var numberA = 5.00;
            var numberB = 10.00;
            var expectedResult = 15.00;

            // --- Act
            var result = _service.Sum(numberA, numberB);

            // --- Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void DivideInt()
        {
            // --- Arrange
            var numberA = 10;
            var numberB = 2;
            var expectedResult = 5;

            // --- Act
            var result = _service.Divide(numberA, numberB);

            // --- Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void DivideDouble()
        {
            // --- Arrange
            var numberA = 10.00;
            var numberB = 2.00;
            var expectedResult = 5.00;

            // --- Act
            var result = _service.Divide(numberA, numberB);

            // --- Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void DivideByZero()
        {
            // --- Arrange
            var numberA = 10;
            var numberB = 0;

            // --- Act
            var result = Assert.Throws<DivideByZeroException>(() => { _service.Divide(numberA, numberB); });

            // --- Assert
            Assert.NotNull(result);
            Assert.Equal("You can't do that!", result.Message);
        }
    }
}