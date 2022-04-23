using System.Windows;
using System.Windows.Controls;

namespace TossBinding.UI.Units
{
    public class StockListBox : ListBox
    {
        #region DefaultStyleKey

        static StockListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StockListBox), new FrameworkPropertyMetadata(typeof(StockListBox)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new StockListItem();
        }
        #endregion
    }
}
