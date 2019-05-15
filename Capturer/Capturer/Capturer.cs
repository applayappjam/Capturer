using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capturer
{
    public partial class Capturer : Form
    {
        private Status status = new Status();

        public Capturer()
        {
            InitializeComponent();
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
            MessageBox.Show("단축키 변경하는 폼 실행");
        }

        private void fullScreenRadioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("전체화면 캡쳐");
            status.SelectedMode = 0;
        }

        private void programRadioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램 캡쳐");
            status.SelectedMode = 1;
        }

        private void dragRadioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("드래그 캡쳐");
            status.SelectedMode = 2;
        }

        private void clipboardRadioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("클립보드에 저장");
            status.SelectedSaveMode = 0;
        }

        private void desktopSaveRadioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("바탕화면에 저장");
            status.SelectedSaveMode = 1;
        }

        private void userPathRadioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("사용자 경로 설정하는 폴더다이얼로그 실행");
            status.SelectedSaveMode = 2;
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
            this.selectedPath = "test";
            this.selectedSaveMode = 0; // 클립보드 저장을 디폴트로 지정
            this.selectedHotKey = "test";
        }
    }
}
