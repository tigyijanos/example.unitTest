namespace MySoftware.Module.CalculatorFromContainer
{
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for CalculatorFromContainerView.xaml
    /// </summary>
    public partial class CalculatorFromContainerView : UserControl
    {
        public CalculatorFromContainerView()
        {
            InitializeComponent();
            DataContext = new CalculatorFromContainerViewModel();
        }
    }
}
