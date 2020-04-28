using System.ComponentModel;
using System.Runtime.CompilerServices;
using ViewModelTest.Annotations;

namespace ViewModelTest.Model
{
    public class Device : INotifyPropertyChanged
    {
        private string _name;
        private string _stringProperty;
        private int _intProperty;
        private bool _boolProperty1;
        private bool _boolProperty2;

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

        public string StringProperty
        {
            get => _stringProperty;
            set
            {
                _stringProperty = value;
                OnPropertyChanged();
            }
        }

        public int IntProperty
        {
            get => _intProperty;
            set
            {
                _intProperty = value;
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

        public IDeviceFunction DeviceFunction { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}