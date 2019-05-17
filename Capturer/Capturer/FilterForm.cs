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

        public void FilterForm_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            startP = new Point(e.X, e.Y);
        }

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

                if (MainForm.status.SelectedSaveMode == 0)
                {
                    Clipboard.SetImage(dragmap);
                    this.Dispose();
                }
                else
                {
                    dragmap.Save(MainForm.status.SelectedPath + @"\test.png");
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
