using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c샵_마우스좌표
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Click += new EventHandler(Button1_MouseClick);
        }


        private void Button1_MouseClick(object sender, EventArgs e)
        {
            Form1 showForm1 = new Form1();
            showForm1.ShowDialog();
        }

    }
}
