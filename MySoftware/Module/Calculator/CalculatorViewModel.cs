namespace MySoftware.Module.Calculator
{
    using System;
    using System.Globalization;
    using System.Windows;

    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;

    using MySoftware.Service;

    public class CalculatorViewModel : ViewModelBase
    {
        private readonly IMathService _mathService;

        private string _inputA;

        private string _inputB;

        private string _result;

        private RelayCommand _sumCommand;

        private RelayCommand _divideCommand;

        public CalculatorViewModel()
        {
            _mathService = new MathService();
        }

        public string InputA
        {
            get => _inputA;
            set => Set(ref _inputA, value);
        }

        public string InputB
        {
            get => _inputB;
            set => Set(ref _inputB, value);
        }

        public string Result
        {
            get => _result;
            set => Set(ref _result, value);
        }

        public RelayCommand DivideCommand => _divideCommand ?? (_divideCommand = new RelayCommand(Divide));

        public RelayCommand SumCommand => _sumCommand ?? (_sumCommand = new RelayCommand(Sum));

        private void Sum()
        {
            if (double.TryParse(InputA, out var intA) && double.TryParse(InputB, out var intB))
            {
                Result = _mathService.Sum(intA, intB).ToString(CultureInfo.InvariantCulture);
            }
        }

        private void Divide()
        {
            if (double.TryParse(InputA, out var intA) && double.TryParse(InputB, out var intB))
            {
                try
                {
                    Result = _mathService.Divide(intA, intB).ToString(CultureInfo.InvariantCulture);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }
    }
}