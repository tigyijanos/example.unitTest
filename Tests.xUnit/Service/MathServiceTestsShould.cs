namespace Tests.xUnit.Service
{
    using System;

    using MySoftware.Service;

    using Should;

    using Xunit;

    /// <summary>
    /// This class tests MathService using Should nuget package
    /// </summary>
    public class MathServiceTestsShould : IDisposable
    {
        private static MathService _service;

        public MathServiceTestsShould()
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
            result.ShouldEqual(expectedResult);
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
            result.ShouldEqual(expectedResult);
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
            result.ShouldEqual(expectedResult);
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
            result.ShouldEqual(expectedResult);
        }

        [Fact]
        public void DivideByZero()
        {
            // --- Arrange
            var numberA = 10;
            var numberB = 0;
            DivideByZeroException result = null;

            // --- Act
            try
            {
                _service.Divide(numberA, numberB);
            }
            catch (DivideByZeroException ex)
            {
                result = ex;
            }

            // --- Assert
            result.ShouldNotBeNull();
            // ReSharper disable once PossibleNullReferenceException
            result.Message.ShouldEqual("You can't do that!");
        }

        [Fact]
        public void XUnitShouldFail()
        {
            // --- Arrange
            var numberA = 10.00;
            var numberB = 2.00;

            // Wrong expectedResult just for demonstration
            var expectedResult = 15.00;

            // --- Act
            var result = _service.Divide(numberA, numberB);

            // --- Assert
            result.ShouldEqual(expectedResult);
        }

        [Fact(Skip = "Not implemented")]
        public void XUnitSkip()
        {
        }
    }
}