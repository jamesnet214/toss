using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Toss.UI.Views;

namespace Toss
{
    internal class App : Application
    {
        public App()
        {
            Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            // MainWindow 인스턴스 생성
            MainWindow main = new();
            MainWindow = main;
            main.Show();

        }
    }
}
