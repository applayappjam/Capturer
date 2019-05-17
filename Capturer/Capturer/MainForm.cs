using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;

namespace Capturer
{
    public partial class MainForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public static Status status = new Status();
        NotifyIcon notifyicon = new NotifyIcon();

        public MainForm()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            string stkey = key.ToString();
            if((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                MessageBox.Show(Keys.Control + " + " + stkey);
            }

            if (stkey == MainForm.status.SelectedHotKey)
            {
                this.Visible = false;
                if (status.SelectedMode == 0) // 전체화면
                {
                    SetProcessDPIAware();
                    Size size = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

                    Bitmap bitmap = new Bitmap(size.Width, size.Height);
                    Graphics g = Graphics.FromImage(bitmap);
                    g.CopyFromScreen(0, 0, 0, 0, size);

                    if (status.SelectedSaveMode == 0)
                    {
                        Clipboard.SetImage(bitmap);
                    }
                    else
                    {
                        bitmap.Save(status.SelectedPath + @"\test.png");
                    }
                }
                else if (status.SelectedMode == 1) // 프로그램 캡쳐
                {

                }

                else // 영역 캡쳐
                {
                    Thread.Sleep(300);
                    FilterForm filterForm = new FilterForm();
                    filterForm.Show();
                }
            }
        }

        private void Notify_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowIcon = false;

                notifyIcon1.Visible = true;
            }
        }

        private void notifyicon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.ShowIcon = true;

            this.WindowState = FormWindowState.Normal;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        /// <summary>
        /// 단축키 변경 버튼을 클릭했을 때 실행되는 메소드
        /// 새로운 Form을 실행해서 단축키 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hoyKeyChangeButton_Click(object sender, EventArgs e)
        {
            HotKeyForm hotKeyForm = new HotKeyForm();
            hotKeyForm.ShowDialog();
            // ShowDialog() kill한 후에
            // currentHotKeyTextBox.Text = status.SelectedHotKey;
        }

        private void fullScreenRadioBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("전체화면 캡쳐");
            status.SelectedMode = 0;
        }

        private void programRadioBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("프로그램 선택하는 새로운 폼 팝업");
            status.SelectedMode = 1;
        }

        private void dragRadioBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("드래그 캡쳐");
            status.SelectedMode = 2;
        }

        private void clipboardRadioBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("클립보드에 저장");
            status.SelectedSaveMode = 0;
            this.currentPathTextBox.Text = "Clipboard";
        }

        private void desktopSaveRadioBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("바탕화면에 저장");
            status.SelectedSaveMode = 1;
            status.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            this.currentPathTextBox.Text = status.SelectedPath;
        }

        private void userPathRadioBtn_Click(object sender, EventArgs e)
        {
            status.SelectedSaveMode = 2;

            // 폴더 선택 다이얼로그
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            status.SelectedPath = dialog.SelectedPath;
            this.currentPathTextBox.Text = status.SelectedPath;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try {
                System.Diagnostics.Process.Start("https://github.com/applayappjam/Capturer");
            } catch {
                MessageBox.Show("error");
            }
        }

        private void Capturer_Load(object sender, EventArgs e)
        {

        }

        private void userPathRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (status.SelectedMode == 0) // 전체화면
            {
                SetProcessDPIAware();
                Size size = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

                Bitmap bitmap = new Bitmap(size.Width, size.Height);
                Graphics g = Graphics.FromImage(bitmap);
                g.CopyFromScreen(0, 0, 0, 0, size);
                
                if(status.SelectedSaveMode == 0)
                {
                    Clipboard.SetImage(bitmap);
                }
                else
                {
                    bitmap.Save(status.SelectedPath + @"\test.png");
                }
            }
            else if (status.SelectedMode == 1) // 프로그램 캡쳐
            {
                ProcessListForm processListForm = new ProcessListForm();
                processListForm.Show();
            }

            else // 영역 캡쳐
            {
                Thread.Sleep(500);
                FilterForm filterForm = new FilterForm();
                filterForm.Show();
            }
        }
    }

    /// <summary>
    /// 현재 설정된 값들을 저장하는 클래스
    /// </summary>
    public class Status
    {
        private int selectedMode;                       // 현재 설정된 촬영 모드
        public int SelectedMode {
            get { return selectedMode; }
            set { this.selectedMode = value; }
        }

        private string selectedPath;      // 현재 설정된 경로 주소
        public string SelectedPath {
            get { return selectedPath; }
            set { this.selectedPath = value; }
        }

        private int selectedSaveMode;                   // 현재 설정된 경로 모드
        public int SelectedSaveMode {
            get { return selectedSaveMode; }
            set { this.selectedSaveMode = value; }
        }

        private string selectedHotKey;              // 현재 설정된 단축키
        public string SelectedHotKey {
            get { return selectedHotKey; }
            set { this.selectedHotKey = value; }
        }

        public Status() {
            this.selectedMode = 2; // 드래그 캡쳐를 디폴트로 지정
            this.selectedPath = "";
            this.selectedSaveMode = 0; // 클립보드 저장을 디폴트로 지정
            this.selectedHotKey = "Control + O";
        }
    }
}
