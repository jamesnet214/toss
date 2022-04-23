
using System.Windows;
using System.Windows.Controls;

namespace TossBinding.UI.Units
{
    public class StockListItem : ListBoxItem
    {
        #region DefaultStyleKey

        static StockListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StockListItem), new FrameworkPropertyMetadata(typeof(StockListItem)));
        }
        #endregion
    }
}
