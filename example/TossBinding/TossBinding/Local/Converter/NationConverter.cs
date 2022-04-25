using System;
using System.Globalization;
using System.Windows.Data;

namespace TossBinding.Local.Converter
{
    public class NationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string nationUrl = $"/TossBinding;component/Themes/Images/Stock/{value}.png";

            return nationUrl;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
