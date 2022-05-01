using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Toss.Local.Model;

namespace Toss.Local.Converter
{
    internal class RealtimeValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Stock stock = (Stock)value;
            double rate = (stock.LiveValue - stock.PastValue) / stock.PastValue * 100;
            return $"{rate:+0.0;-#.0}%";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
