using System.ComponentModel;
using System.Runtime.CompilerServices;
using ViewModelTest.Annotations;

namespace ViewModelTest.Model
{
    public class DeviceFunction2 : IDeviceFunction, INotifyPropertyChanged
    {
        private string _name;
        private string _stringProperty1;
        private string _stringProperty2;
        private bool _boolProperty1;
        private bool _boolProperty2;
        private bool _boolProperty3;
        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string StringProperty1
        {
            get => _stringProperty1;
            set
            {
                _stringProperty1 = value;
                OnPropertyChanged();
            }
        }

        public string StringProperty2
        {
            get => _stringProperty2;
            set
            {
                _stringProperty2 = value;
                OnPropertyChanged();
            }
        }

        public bool BoolProperty1
        {
            get => _boolProperty1;
            set
            {
                if (value == _boolProperty1) return;
                _boolProperty1 = value;
                OnPropertyChanged();
            }
        }

        public bool BoolProperty2
        {
            get => _boolProperty2;
            set
            {
                if (value == _boolProperty2) return;
                _boolProperty2 = value;
                OnPropertyChanged();
            }
        }

        public bool BoolProperty3
        {
            get => _boolProperty3;
            set
            {
                if (value == _boolProperty3) return;
                _boolProperty3 = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}