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
    public class Status
    {
        // 현재 정보 저장
        private int currentMode = 0;                    // 현재 설정된 촬영 모드
        public int CurrentMode {
            get { return currentMode; }
            set { }
        }

        private string currentPath = "current path";    // 현재 설정된 경로 주소
        public string CurrentPath {
            get { return currentPath; }
            set { }
        }

        private int pathMode = 0;                       // 현재 설정된 경로 모드
        public int PathMode {
            get { return pathMode; }
            set { }
        }

        private string currentHotKey = "key";           // 현재 설정된 단축키
        public string CurrentHotKey {
            get { return currentHotKey; }
            set { }
        }
    }

    public partial class Capturer : Form
    {
        public Capturer()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // 여기부터 이벤트 정의
        private void hoyKeyChangeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("변경 완료!");
        }

    }
}
