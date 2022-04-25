using System;

namespace TossBinding2
{
    internal class Starter
    {
        [STAThread]
        static void Main(string[] args)
        {
            _ = new App().Run();
        }
    }
}
