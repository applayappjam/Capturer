using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessPractice
{
    public partial class Form1 : Form
    {
        MyProcess myprocess = new MyProcess();

        public Form1()
        {
            InitializeComponent();

            for(int i = 0; i < myprocess.process.Length; i++)
            {
                if(myprocess.process[i].MainWindowTitle.Length > 0 ||
                    myprocess.process[i].ProcessName == "explorer")
                {
                    this.label1.Text += myprocess.process[i].ProcessName + "   "
                        + myprocess.process[i].Id + "   "
                        + myprocess.process[i].MainWindowTitle + "\n";
                }
            }
        }

        public class MyProcess
        {
            public Process[] process;
            public MyProcess()
            {
                process = Process.GetProcesses();
            }
        }
    }
}
