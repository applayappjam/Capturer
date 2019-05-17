namespace Capturer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dragRadioBtn = new System.Windows.Forms.RadioButton();
            this.programRadioBtn = new System.Windows.Forms.RadioButton();
            this.fullScreenRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userPathRadioBtn = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentPathLabel = new System.Windows.Forms.Label();
            this.currentPathTextBox = new System.Windows.Forms.TextBox();
            this.desktopSaveRadioBtn = new System.Windows.Forms.RadioButton();
            this.clipboardRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentHotKeyTextBox = new System.Windows.Forms.TextBox();
            this.hoyKeyChangeButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel.Location = new System.Drawing.Point(14, 15);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(297, 422);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.groupBox1.Controls.Add(this.dragRadioBtn);
            this.groupBox1.Controls.Add(this.programRadioBtn);
            this.groupBox1.Controls.Add(this.fullScreenRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(291, 111);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "▶︎ 촬영 모드";
            // 
            // dragRadioBtn
            // 
            this.dragRadioBtn.AutoSize = true;
            this.dragRadioBtn.BackColor = System.Drawing.Color.White;
            this.dragRadioBtn.Checked = true;
            this.dragRadioBtn.Location = new System.Drawing.Point(7, 81);
            this.dragRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dragRadioBtn.Name = "dragRadioBtn";
            this.dragRadioBtn.Size = new System.Drawing.Size(68, 21);
            this.dragRadioBtn.TabIndex = 2;
            this.dragRadioBtn.TabStop = true;
            this.dragRadioBtn.Text = "드래그";
            this.dragRadioBtn.UseVisualStyleBackColor = false;
            this.dragRadioBtn.Click += new System.EventHandler(this.dragRadioBtn_Click);
            // 
            // programRadioBtn
            // 
            this.programRadioBtn.AutoSize = true;
            this.programRadioBtn.Location = new System.Drawing.Point(7, 54);
            this.programRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.programRadioBtn.Name = "programRadioBtn";
            this.programRadioBtn.Size = new System.Drawing.Size(110, 21);
            this.programRadioBtn.TabIndex = 1;
            this.programRadioBtn.Text = "프로그램 선택";
            this.programRadioBtn.UseVisualStyleBackColor = true;
            this.programRadioBtn.Click += new System.EventHandler(this.programRadioBtn_Click);
            // 
            // fullScreenRadioBtn
            // 
            this.fullScreenRadioBtn.AutoSize = true;
            this.fullScreenRadioBtn.Location = new System.Drawing.Point(7, 26);
            this.fullScreenRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullScreenRadioBtn.Name = "fullScreenRadioBtn";
            this.fullScreenRadioBtn.Size = new System.Drawing.Size(81, 21);
            this.fullScreenRadioBtn.TabIndex = 0;
            this.fullScreenRadioBtn.Text = "전체화면";
            this.fullScreenRadioBtn.UseVisualStyleBackColor = true;
            this.fullScreenRadioBtn.Click += new System.EventHandler(this.fullScreenRadioBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.groupBox2.Controls.Add(this.userPathRadioBtn);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.desktopSaveRadioBtn);
            this.groupBox2.Controls.Add(this.clipboardRadioBtn);
            this.groupBox2.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(3, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(291, 148);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "▶︎ 저장경로 설정";
            // 
            // userPathRadioBtn
            // 
            this.userPathRadioBtn.AutoSize = true;
            this.userPathRadioBtn.Location = new System.Drawing.Point(8, 81);
            this.userPathRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userPathRadioBtn.Name = "userPathRadioBtn";
            this.userPathRadioBtn.Size = new System.Drawing.Size(97, 21);
            this.userPathRadioBtn.TabIndex = 0;
            this.userPathRadioBtn.Text = "사용자 지정";
            this.userPathRadioBtn.UseVisualStyleBackColor = true;
            this.userPathRadioBtn.CheckedChanged += new System.EventHandler(this.userPathRadioBtn_CheckedChanged);
            this.userPathRadioBtn.Click += new System.EventHandler(this.userPathRadioBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.currentPathLabel);
            this.flowLayoutPanel1.Controls.Add(this.currentPathTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 105);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 36);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // currentPathLabel
            // 
            this.currentPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentPathLabel.AutoSize = true;
            this.currentPathLabel.Location = new System.Drawing.Point(3, 8);
            this.currentPathLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentPathLabel.Name = "currentPathLabel";
            this.currentPathLabel.Size = new System.Drawing.Size(92, 17);
            this.currentPathLabel.TabIndex = 0;
            this.currentPathLabel.Text = "→ 설정된 경로";
            // 
            // currentPathTextBox
            // 
            this.currentPathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(211)))));
            this.currentPathTextBox.Location = new System.Drawing.Point(101, 4);
            this.currentPathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentPathTextBox.Name = "currentPathTextBox";
            this.currentPathTextBox.ReadOnly = true;
            this.currentPathTextBox.Size = new System.Drawing.Size(173, 25);
            this.currentPathTextBox.TabIndex = 1;
            this.currentPathTextBox.TabStop = false;
            this.currentPathTextBox.Text = "Clipboard";
            // 
            // desktopSaveRadioBtn
            // 
            this.desktopSaveRadioBtn.AutoSize = true;
            this.desktopSaveRadioBtn.Location = new System.Drawing.Point(8, 54);
            this.desktopSaveRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.desktopSaveRadioBtn.Name = "desktopSaveRadioBtn";
            this.desktopSaveRadioBtn.Size = new System.Drawing.Size(81, 21);
            this.desktopSaveRadioBtn.TabIndex = 0;
            this.desktopSaveRadioBtn.Text = "바탕화면";
            this.desktopSaveRadioBtn.UseVisualStyleBackColor = true;
            this.desktopSaveRadioBtn.Click += new System.EventHandler(this.desktopSaveRadioBtn_Click);
            // 
            // clipboardRadioBtn
            // 
            this.clipboardRadioBtn.AutoSize = true;
            this.clipboardRadioBtn.BackColor = System.Drawing.Color.White;
            this.clipboardRadioBtn.Checked = true;
            this.clipboardRadioBtn.Location = new System.Drawing.Point(8, 26);
            this.clipboardRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clipboardRadioBtn.Name = "clipboardRadioBtn";
            this.clipboardRadioBtn.Size = new System.Drawing.Size(81, 21);
            this.clipboardRadioBtn.TabIndex = 0;
            this.clipboardRadioBtn.TabStop = true;
            this.clipboardRadioBtn.Text = "클립보드";
            this.clipboardRadioBtn.UseVisualStyleBackColor = false;
            this.clipboardRadioBtn.Click += new System.EventHandler(this.clipboardRadioBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.groupBox3.Controls.Add(this.flowLayoutPanel2);
            this.groupBox3.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(3, 279);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(291, 61);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "▶︎ 단축키";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.currentHotKeyTextBox);
            this.flowLayoutPanel2.Controls.Add(this.hoyKeyChangeButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 18);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(281, 36);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // currentHotKeyTextBox
            // 
            this.currentHotKeyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentHotKeyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(211)))));
            this.currentHotKeyTextBox.Location = new System.Drawing.Point(3, 6);
            this.currentHotKeyTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentHotKeyTextBox.Name = "currentHotKeyTextBox";
            this.currentHotKeyTextBox.ReadOnly = true;
            this.currentHotKeyTextBox.Size = new System.Drawing.Size(219, 25);
            this.currentHotKeyTextBox.TabIndex = 1;
            this.currentHotKeyTextBox.TabStop = false;
            this.currentHotKeyTextBox.Text = " ";
            this.currentHotKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoyKeyChangeButton
            // 
            this.hoyKeyChangeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hoyKeyChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(182)))));
            this.hoyKeyChangeButton.Location = new System.Drawing.Point(228, 4);
            this.hoyKeyChangeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hoyKeyChangeButton.Name = "hoyKeyChangeButton";
            this.hoyKeyChangeButton.Size = new System.Drawing.Size(48, 29);
            this.hoyKeyChangeButton.TabIndex = 2;
            this.hoyKeyChangeButton.TabStop = false;
            this.hoyKeyChangeButton.Text = "변경";
            this.hoyKeyChangeButton.UseVisualStyleBackColor = false;
            this.hoyKeyChangeButton.Click += new System.EventHandler(this.hoyKeyChangeButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.groupBox4.Controls.Add(this.linkLabel1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(3, 348);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(291, 70);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "▶︎ Info";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(12, 6);
            this.linkLabel1.Location = new System.Drawing.Point(5, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 23);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Feedback -> GitHub";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "2019년 1학기 Applay 앱잼";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Capturer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyicon_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(325, 458);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Capturer";
            this.Load += new System.EventHandler(this.Capturer_Load);
            this.Resize += new System.EventHandler(this.Notify_Resize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label currentPathLabel;
        private System.Windows.Forms.TextBox currentPathTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton programRadioBtn;
        private System.Windows.Forms.RadioButton fullScreenRadioBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton dragRadioBtn;
        private System.Windows.Forms.RadioButton userPathRadioBtn;
        private System.Windows.Forms.RadioButton desktopSaveRadioBtn;
        private System.Windows.Forms.RadioButton clipboardRadioBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox currentHotKeyTextBox;
        private System.Windows.Forms.Button hoyKeyChangeButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

