namespace Tests.xUnit.Module.CalculatorFromContainer
{
    using System.Globalization;

    using MySoftware.Module.Calculator;

    using Xunit;

    /// <summary>
    /// This class tests CalculatorFromContainerViewModel using Xunit Assert
    /// </summary>
    public class CalculatorFromContainerViewModelTests
    {
        [Fact]
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
            Assert.Equal(viewModel.Result, expectedResult);
        }

        [Fact]
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
            Assert.Equal(viewModel.Result, expectedResult);
        }

        [Fact]
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
            Assert.Equal(viewModel.Result, expectedResult);
        }

        [Fact]
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
            Assert.Equal(viewModel.Result, expectedResult);
        }
    }
}