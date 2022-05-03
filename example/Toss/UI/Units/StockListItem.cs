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
