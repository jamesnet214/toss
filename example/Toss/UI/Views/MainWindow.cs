using System.Windows;
using System.Windows.Controls;
using Toss.Local.ViewModel;

namespace Toss.UI.Views
{
    public class MainWindow : Window
    {
        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }

        public MainWindow()
        {
            Topmost = true;
        }
    }
}
