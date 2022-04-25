using System.Windows;
using System.Windows.Controls;

namespace TossBinding2.UI.Units
{
    public class StockListBox : Control
    {
        #region DefaultStyleKey

        static StockListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StockListBox), new FrameworkPropertyMetadata(typeof(StockListBox)));
        }
        #endregion
    }
}
