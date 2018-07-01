namespace Tests.MSTest.Service
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using MySoftware.Service;

    using Should;

    /// <summary>
    /// This class tests MathService using Should nuget package
    /// </summary>
    [TestClass]
    public class MathServiceTestsShould
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
            result.ShouldEqual(expectedResult);
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
            result.ShouldEqual(expectedResult);
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
            result.ShouldEqual(expectedResult);
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
            result.ShouldEqual(expectedResult);
        }

        [TestMethod]
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

        [TestMethod]
        public void MsTestShouldFail()
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

        [Ignore("Not implemented")]
        [TestMethod]
        public void MsTestSkip()
        {
        }
    }
}