using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace UncleBros.ViewModel
{
    // 1. switch 값에 따라 라벨의 Text값이 변경
    // 2. switch 값에 따라 라벨의 Text값과 폰트컬러가 변경
    // 3. switch 값에 따라 라벨의 Text 폰트값과 백그라운드값이 변경
    public class BoolToObjectConverterViewModel : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(string))
            {
                return (bool)value ? "Yes" : "No Way";
            }
            else if (targetType == typeof(Color))
            {
                if ((string)parameter == "TextColor")
                {
                    return (bool)value ? Color.White : Color.Black;
                }
                else if ((string)parameter == "BackgroundColor")
                {
                    return (bool)value ? Color.Black : Color.White;
                }
                else if ((string)parameter == "SwitchTextColor")
                {
                    return (bool)value ? Color.Blue : Color.Red;
                }
            }

            return null;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
