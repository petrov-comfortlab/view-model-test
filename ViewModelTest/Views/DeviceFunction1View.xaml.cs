using ViewModelTest.Model;
using ViewModelTest.ViewModels;

namespace ViewModelTest.Views
{
    public partial class DeviceFunction1View
    {
        public DeviceFunction1View(DeviceFunction1 deviceFunction)
        {
            InitializeComponent();
            DataContext = new DeviceFunction1ViewModel(deviceFunction);
        }
    }
}