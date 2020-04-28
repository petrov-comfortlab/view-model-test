using ViewModelTest.Model;
using ViewModelTest.ViewModels;

namespace ViewModelTest.Views
{
    public partial class DeviceFunction2View
    {
        public DeviceFunction2View(DeviceFunction2 deviceFunction)
        {
            InitializeComponent();
            DataContext = new DeviceFunction2ViewModel(deviceFunction);
        }
    }
}