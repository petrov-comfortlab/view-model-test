using ViewModelTest.Model;

namespace ViewModelTest.ViewModels
{
    public class DeviceViewModel
    {
        public DeviceViewModel(Device device)
        {
            Device = device;
        }

        public Device Device { get; set; }
    }
}