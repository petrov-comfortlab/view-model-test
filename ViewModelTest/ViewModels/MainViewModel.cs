using System.Collections.ObjectModel;
using System.Linq;
using ViewModelTest.Model;

namespace ViewModelTest.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel() => Devices = new ObservableCollection<DeviceViewModel>(DeviceRepository.Devices.Select(n => new DeviceViewModel(n)));

        public ObservableCollection<DeviceViewModel> Devices { get; set; }
    }
}