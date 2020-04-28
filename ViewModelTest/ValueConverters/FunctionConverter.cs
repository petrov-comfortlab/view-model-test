using System;
using System.Globalization;
using System.Windows.Data;
using ViewModelTest.Model;
using ViewModelTest.Views;

namespace ViewModelTest
{
    public class FunctionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case DeviceFunction1 deviceFunction:
                    return new DeviceFunction1View(deviceFunction);

                case DeviceFunction2 deviceFunction:
                    return new DeviceFunction2View(deviceFunction);

                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}