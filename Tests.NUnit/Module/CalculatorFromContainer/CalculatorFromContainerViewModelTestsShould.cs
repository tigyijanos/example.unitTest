// ReSharper disable once StyleCop.SA1200
using NUnit.Framework;

namespace Tests.NUnit.Module.CalculatorFromContainer
{
    using System.Globalization;

    using GalaSoft.MvvmLight.Ioc;

    using MySoftware.Module.CalculatorFromContainer;
    using MySoftware.Service;

    using Should;

    /// <summary>
    /// This class tests CalculatorFromContainerViewModel using Should nuget package
    /// </summary>
    [TestFixture]
    public class CalculatorFromContainerViewModelTestsShould
    {
        [SetUp]
        public void ClassInitialize()
        {
            SimpleIoc.Default.Register<IMathService, MathService>();
        }

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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