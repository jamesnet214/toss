using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toss
{
    internal class Starter
    {
        // 프로그램 시작점
        [STAThread]
        static void Main(string[] args)
        {
            // App 구동
            _ = new App().Run();
        }
    }
}
