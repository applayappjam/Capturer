// Capturer(가명) - 캡쳐 프로그램(Windows 10)
// 2019.05.17~18 Applay 앱잼

// 2019.05.14 v0.0 프로젝트 생성

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capturer
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Capturer());
        }
    }
}
