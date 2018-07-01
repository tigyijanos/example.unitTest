namespace MySoftware.Module.Calculator
{
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for CalculatorView.xaml
    /// </summary>
    public partial class CalculatorView : UserControl
    {
        public CalculatorView()
        {
            InitializeComponent();
            DataContext = new CalculatorViewModel();
        }
    }
}
