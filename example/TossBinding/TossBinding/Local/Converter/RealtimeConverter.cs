using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using TossBinding.Local.Model;

namespace TossBinding.Local.Converter
{
    public class RealtimeConverter : IValueConverter
    {
        public int Price { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Stock stock = (Stock)value;

            double todayPrice = stock.TodayPrice;
            double closingPrice = stock.ClosingPrice;

            double returnPrice = todayPrice - closingPrice;
            double realtime = returnPrice / closingPrice * 100;
            string sign = stock.Plus ? "+" : "";

            return $"{sign}{realtime.ToString("N1")}%";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
