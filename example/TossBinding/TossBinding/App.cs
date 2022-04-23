using System.Windows;
using TossBinding.UI.Views;

namespace TossBinding
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow main = new();
            main.ShowDialog();
        }
    }
}