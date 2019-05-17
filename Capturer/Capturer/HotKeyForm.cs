using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capturer;

namespace Capturer
{
    public partial class HotKeyForm : Form
    {
        public HotKeyForm()
        {
            InitializeComponent();
            this.currentHotKey.Text = MainForm.status.SelectedHotKey;
        }

        private void HotKeyForm_Load(object sender, EventArgs e)
        {

        }

        private void KeyDownHotKey(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            string stkey = key.ToString();
            string CtrKey = "Ctrl + " + stkey;          
            if (key == Keys.Escape)
            {
                MessageBox.Show("Esc는 단축키로 지정할 수 없습니다!");                
            }
            //Ctrl + 키 입력시
            else if (e.Control == true)
            {
                this.NewHotKey.Text = CtrKey;
            }
            //키 입력시
            else
                this.NewHotKey.Text = stkey;
        }

        private void ChangeHotKey(object sender, EventArgs e)
        {
            this.currentHotKey.Text = this.NewHotKey.Text;
            Capturer.MainForm.status.SelectedHotKey = currentHotKey.Text;
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
