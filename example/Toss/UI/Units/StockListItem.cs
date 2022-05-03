using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Toss.UI.Units
{
    internal class StockListItem : ListBoxItem
    {
        static StockListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StockListItem), new FrameworkPropertyMetadata(typeof(StockListItem)));
        }
    }
}
