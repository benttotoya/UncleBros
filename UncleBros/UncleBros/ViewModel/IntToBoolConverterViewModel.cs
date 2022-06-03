using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace UncleBros.ViewModel
{
    public class IntToBoolConverterViewModel : IValueConverter
    {
        // Source -> Target
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value !=0 ? true : false;
        }

        // Target -> Source
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }
}
