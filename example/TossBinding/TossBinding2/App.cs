using System.Windows;
using TossBinding2.UI.Views;

namespace TossBinding2
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
