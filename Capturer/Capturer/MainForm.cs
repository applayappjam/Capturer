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
        // 해상도 및 디스플레이 배율 구하기
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public static Status status = new Status();
        NotifyIcon notifyicon = new NotifyIcon();

        public MainForm()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
        }

        /// <summary>
        /// MainForm에서 단축키에 해당하는 입력을 받으면 캡쳐를 시작합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            string stkey = key.ToString();

            // 현재 Control만 구현돼있고, Alt, Shift 추가 구현해야 함
            if((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                // test
                MessageBox.Show(Keys.Control + " + " + stkey);
            }

            if (stkey == MainForm.status.selectedHotKey)
            {
                this.Visible = false;
                if (status.selectedMode == 0) // 전체화면
                {
                    SetProcessDPIAware();
                    Size size = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

                    Bitmap bitmap = new Bitmap(size.Width, size.Height);
                    Graphics g = Graphics.FromImage(bitmap);
                    g.CopyFromScreen(0, 0, 0, 0, size);

                    if (status.selectedSaveMode == 0)
                    {
                        Clipboard.SetImage(bitmap);
                    }
                    else
                    {
                        bitmap.Save(status.selectedPath + @"\test.png");
                    }
                }
                else if (status.selectedMode == 1) // 프로그램 캡쳐
                {
                    // ProcessListForm 생성하고 ProcessName값 받아서 캡쳐 구현해야 함
                }

                else // 영역 캡쳐
                {
                    Thread.Sleep(300); // 창이 내려가다가 찍히는 것을 방지하기 위해 딜레이
                    FilterForm filterForm = new FilterForm();
                    filterForm.Show();
                }
            }
        }

        /// <summary>
        /// Resize 이벤트 정의
        /// 윈도우 상태가 최소화가 되면 트레이아이콘 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Notify_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowIcon = false;

                notifyIcon1.Visible = true;
            }
        }

        /// <summary>
        /// DoubleClick 이벤트 정의
        /// 트레이 아이콘이 더블클릭되면 MainForm 다시 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// HotKeyForm 실행해서 단축키 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hoyKeyChangeButton_Click(object sender, EventArgs e)
        {
            HotKeyForm hotKeyForm = new HotKeyForm();
            hotKeyForm.ShowDialog();

            // 매우 중요한 issue
            // ShowDialog()이 종료될 때 변경된 단축키 값을 status에 적용시켜야 하는데 이 부분이 안됨
        }

        /// <summary>
        /// '전체화면 캡처' 라디오 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fullScreenRadioBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("전체화면 캡쳐");
            status.selectedMode = 0;
        }

        /// <summary>
        /// '프로그램 캡쳐' 라디오 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void programRadioBtn_Click(object sender, EventArgs e)
        {
            // 프로그램 선택은 캡쳐할 때 선택, 여기서는 no
            status.selectedMode = 1;
        }

        /// <summary>
        /// '드래그 캡쳐' 라디오 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dragRadioBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("드래그 캡쳐");
            status.selectedMode = 2;
        }

        /// <summary>
        /// '클립보드' 라디오 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clipboardRadioBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("클립보드에 저장");
            status.selectedSaveMode = 0;
            this.currentPathTextBox.Text = "Clipboard";
        }

        /// <summary>
        /// '바탕화면' 라디오 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void desktopSaveRadioBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("바탕화면에 저장");
            status.selectedSaveMode = 1;
            status.selectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            this.currentPathTextBox.Text = status.selectedPath;
        }

        /// <summary>
        /// '사용자 지정' 라디오 버튼 클릭 이벤트
        /// FolderBrowserDialog 띄우고 사용자 지정 경로 설정
        /// 추후 더 일반적인? 창 띄우는 방법으로 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userPathRadioBtn_Click(object sender, EventArgs e)
        {
            status.selectedSaveMode = 2;

            // 폴더 선택 다이얼로그
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            status.selectedPath = dialog.SelectedPath;
            this.currentPathTextBox.Text = status.selectedPath;
        }

        /// <summary>
        /// Feedback 링크 라벨 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 임시 촬영 버튼 구현 (추후 단축키로 구현한 후 삭제)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (status.selectedMode == 0) // 전체화면
            {
                SetProcessDPIAware();
                Size size = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

                Bitmap bitmap = new Bitmap(size.Width, size.Height);
                Graphics g = Graphics.FromImage(bitmap);
                g.CopyFromScreen(0, 0, 0, 0, size);
                
                if(status.selectedSaveMode == 0)
                {
                    Clipboard.SetImage(bitmap);
                }
                else
                {
                    bitmap.Save(status.selectedPath + @"\test.png");
                }
            }
            else if (status.selectedMode == 1) // 프로그램 캡쳐
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
        public int selectedMode { get; set; }           // 설정된 캡쳐 모드
        public string selectedPath { get; set; }        // 설정된 저장 경로
        public int selectedSaveMode { get; set; }       // 설정된 저장 모드
        public string selectedHotKey { get; set; }      // 설정된 단축키

        /// <summary>
        /// 디폴트 생성자
        /// 드래그 캡쳐 및 클립보드 저장을 기본값으로 Status 인스턴스 생성
        /// </summary>
        public Status() {
            this.selectedMode = 2;
            this.selectedPath = "";
            this.selectedSaveMode = 0;
            this.selectedHotKey = "Control + O";
        }
    }
}
