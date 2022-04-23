using System;

namespace TossBinding
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
