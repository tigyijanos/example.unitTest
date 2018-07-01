namespace MySoftware
{
    using System.Windows;

    using GalaSoft.MvvmLight.Ioc;

    using MySoftware.Service;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SimpleIoc.Default.Register<IMathService, MathService>(true);
            InitializeComponent();
        }
    }
}
