// ReSharper disable once StyleCop.SA1200
using NUnit.Framework;

namespace Tests.NUnit.Module.Calculator
{
    using System.Globalization;

    using MySoftware.Module.Calculator;

    using Should;

    /// <summary>
    /// This class tests CalculatorViewModel using Should nuget package
    /// </summary>
    [TestFixture]
    public class CalculatorViewModelTestsShould
    {
        [Test]
        public void SumInt()
        {
            // --- Arrange
            var viewModel = new CalculatorViewModel
            {
                InputA = "5",
                InputB = "10"
            };

            var expectedResult = "15";

            // --- Act
            viewModel.SumCommand.Execute(null);

            // --- Assert
            viewModel.Result.ShouldEqual(expectedResult);
        }

        [Test]
        public void SumDouble()
        {
            // --- Arrange
            var viewModel = new CalculatorViewModel
            {
                InputA = 5.ToString(CultureInfo.InvariantCulture),
                InputB = 10.00.ToString(CultureInfo.InvariantCulture)
            };

            var expectedResult = 15.00.ToString(CultureInfo.InvariantCulture);

            // --- Act
            viewModel.SumCommand.Execute(null);

            // --- Assert
            viewModel.Result.ShouldEqual(expectedResult);
        }

        [Test]
        public void DivideInt()
        {
            // --- Arrange
            var viewModel = new CalculatorViewModel
            {
                InputA = "10",
                InputB = "2"
            };

            var expectedResult = "5";

            // --- Act
            viewModel.DivideCommand.Execute(null);

            // --- Assert
            viewModel.Result.ShouldEqual(expectedResult);
        }

        [Test]
        public void DivideDouble()
        {
            // --- Arrange
            var viewModel = new CalculatorViewModel
            {
                InputA = 10.00.ToString(CultureInfo.InvariantCulture),
                InputB = 2.00.ToString(CultureInfo.InvariantCulture)
            };

            var expectedResult = 5.00.ToString(CultureInfo.InvariantCulture);

            // --- Act
            viewModel.DivideCommand.Execute(null);

            // --- Assert
            viewModel.Result.ShouldEqual(expectedResult);
        }
    }
}