namespace Tests.MSTest.Module.CalculatorFromContainer
{
    using System.Globalization;

    using GalaSoft.MvvmLight.Ioc;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using MySoftware.Module.CalculatorFromContainer;
    using MySoftware.Service;

    using Should;

    /// <summary>
    /// This class tests CalculatorFromContainerViewModel using Should nuget package
    /// </summary>
    [TestClass]
    public class CalculatorFromContainerViewModelTestsShould
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            SimpleIoc.Default.Register<IMathService, MathService>();
        }

        [TestMethod]
        public void SumInt()
        {
            // --- Arrange
            var viewModel = new CalculatorFromContainerViewModel
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

        [TestMethod]
        public void SumDouble()
        {
            // --- Arrange
            var viewModel = new CalculatorFromContainerViewModel
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

        [TestMethod]
        public void DivideInt()
        {
            // --- Arrange
            var viewModel = new CalculatorFromContainerViewModel
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

        [TestMethod]
        public void DivideDouble()
        {
            // --- Arrange
            var viewModel = new CalculatorFromContainerViewModel
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