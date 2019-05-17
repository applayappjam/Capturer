// 2019.05.14 윈폼, 윈도우에서 마우스좌표 구현
// 2019.05.14 버튼클릭시 새로운 윈폼(크기 윈도우)불러와서 좌표나타내는것 구현
// 2019.05.14 전체화면 불러와서 보여주는것 구현 안됨!!!!!!!!!!!!!!!
//2019.05.17 전체화면 캡쳐 구현
//2019.05.17 클립보드 캡쳐 구현

//2019.05.17 해상도 배율문제!!!!!!
//2019.05.17 드래그 캡쳐!!!!!!



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c샵_마우스좌표
{
    public partial class Form1 : Form
    {
        //[DllImport("user32.dll")]
        //static extern bool GetCursorPos(ref Point lpPoint);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public Form1() {
            InitializeComponent();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            //this.WindowState = FormWindowState.Maximized;
            this.Load += new EventHandler(Form1_Load);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
            this.MouseClick += new MouseEventHandler(label1_MouseClick);
            //timer1.Start();

        }

        //public void timer1_Tick(object sender, EventArgs e)
        //{
        //    Point pt = new Point();
        //    GetCursorPos(ref pt);
        //    toolStripStatusLabel1.Text = pt.X.ToString();
        //    toolStripStatusLabel2.Text = pt.Y.ToString();
        //}


        //@@@@@@@@@@@@@@@@ 폼안에서 좌표
        public void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
            toolStripStatusLabel2.Text = "(" + X + ", " + Y + ")";
        }

        public void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           int X = e.X;
           int Y = e.Y;
           toolStripStatusLabel1.Text = "(" + X + ", " + Y + ")";
        }

        public void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
            toolStripStatusLabel3.Text = "(" + X + ", " + Y + ")";
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }




        public void label1_MouseClick(object sender, MouseEventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            SetProcessDPIAware();
            Size size = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            MessageBox.Show(size.Width.ToString() + size.Height.ToString());
            string userPath = @"./test/";

            size.Width = (int)(size.Width * 1.5);
            size.Height = (int)(size.Height * 1.5);
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(0, 0, 0, 0, size);
            // Save
            try {
                //bitmap.Save(userPath + "filename.png"); // 유저가 선택한 경로 or 바탕화면에 저장할 때 이거
                Clipboard.SetImage(bitmap); // 클립보드에 저장할 땐 이거
            }
            catch(ArgumentException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        
    }
}
