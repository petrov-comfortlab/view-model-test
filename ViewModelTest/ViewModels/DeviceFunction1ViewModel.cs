using ViewModelTest.Model;

namespace ViewModelTest.ViewModels
{
    public class DeviceFunction1ViewModel
    {
        public DeviceFunction1ViewModel(DeviceFunction1 deviceFunction1)
        {
            DeviceFunction1 = deviceFunction1;
        }

        public DeviceFunction1 DeviceFunction1 { get; set; }
    }
}