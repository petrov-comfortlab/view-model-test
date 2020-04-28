using ViewModelTest.ViewModels;

namespace ViewModelTest
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}