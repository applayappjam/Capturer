using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Capturer
{
    public partial class FilterForm : Form
    {
        int startX = 0;
        int startY = 0;
        Point startP;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public FilterForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(FilterForm_Load);
            this.MouseDown += new MouseEventHandler(FilterForm_MouseDown);
            this.MouseUp += new MouseEventHandler(FilterForm_MouseUp);
        }

        /// <summary>
        /// FilterForm을 로드하면서 현재 전체화면을 캡쳐해서 저장해놓은 후
        /// 사용자가 드래그한 부분만 잘라내어 저장합니다.
        /// 드래그하여 저장하는 부분은 FilterForm_MouseUp/Down()에서 동작합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FilterForm_Load(object sender, EventArgs e)
        {
            SetProcessDPIAware();
            Size size = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(0, 0, 0, 0, size);
            Clipboard.SetImage(bitmap);
            Image newImage = Clipboard.GetImage();
            this.BackgroundImage = newImage;
        }

        /// <summary>
        /// 마우스가 처음 클릭된 시점의 좌표를 저장합니다.
        /// 드래그 영역은 MouseUp 이벤트가 동작되면 영역이 확정됩니다.
        /// 
        /// 이 부분에 빨간색(예정) 네모를 그리는 코드를 추가해야 함.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FilterForm_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            startP = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 드래그가 끝나는 시점에 발생하는 이벤트입니다.
        /// 드래그 영역을 확정짓고, 이전에 캡쳐한 전체화면에서 좌표만큼만 추출하여 따로 저장합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FilterForm_MouseUp(object sender, MouseEventArgs e)
        {
            int endX = e.X;
            int endY = e.Y;
            Point endP = new Point(e.X, e.Y);
            try {
                int width = Math.Abs(startX - endX);
                int height = Math.Abs(startY - endY);

                Size dragSize = new Size(width, height);
                SetProcessDPIAware();
                Size size = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
                Bitmap dragmap = new Bitmap(size.Width, size.Height);
                Graphics g = Graphics.FromImage(dragmap);
                g.CopyFromScreen(0, 0, 0, 0, size);
                Clipboard.SetImage(dragmap);
                dragmap = dragmap.Clone(new Rectangle(startP.X, startP.Y, dragSize.Width, dragSize.Height), System.Drawing.Imaging.PixelFormat.DontCare);

                if (MainForm.status.selectedSaveMode == 0)
                {
                    Clipboard.SetImage(dragmap);
                    this.Dispose();
                }
                else
                {
                    dragmap.Save(MainForm.status.selectedPath + @"\test.png");
                    this.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error!");
            }
}
    }
}
