
using System.Windows;

namespace TossBinding.UI.Views
{
    public class MainWindow : Window
    {
        #region DefaultStyleKey

        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }
        #endregion
    }
}
