using System.Windows;
using System.Windows.Controls;

namespace Toss.UI.Units
{
    internal class StockListBox : ListBox
    {
        static StockListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StockListBox), new FrameworkPropertyMetadata(typeof(StockListBox)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new StockListItem();
        }
    }
}
