namespace Capturer
{
    partial class Capturer
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
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(260, 338);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dragRadioBtn);
            this.groupBox1.Controls.Add(this.programRadioBtn);
            this.groupBox1.Controls.Add(this.fullScreenRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 89);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "▶︎ 촬영 모드";
            // 
            // dragRadioBtn
            // 
            this.dragRadioBtn.AutoSize = true;
            this.dragRadioBtn.Checked = true;
            this.dragRadioBtn.Location = new System.Drawing.Point(6, 65);
            this.dragRadioBtn.Name = "dragRadioBtn";
            this.dragRadioBtn.Size = new System.Drawing.Size(59, 16);
            this.dragRadioBtn.TabIndex = 2;
            this.dragRadioBtn.TabStop = true;
            this.dragRadioBtn.Text = "드래그";
            this.dragRadioBtn.UseVisualStyleBackColor = true;
            this.dragRadioBtn.Click += new System.EventHandler(this.dragRadioBtn_Click);
            // 
            // programRadioBtn
            // 
            this.programRadioBtn.AutoSize = true;
            this.programRadioBtn.Location = new System.Drawing.Point(6, 43);
            this.programRadioBtn.Name = "programRadioBtn";
            this.programRadioBtn.Size = new System.Drawing.Size(99, 16);
            this.programRadioBtn.TabIndex = 1;
            this.programRadioBtn.Text = "프로그램 선택";
            this.programRadioBtn.UseVisualStyleBackColor = true;
            this.programRadioBtn.Click += new System.EventHandler(this.programRadioBtn_Click);
            // 
            // fullScreenRadioBtn
            // 
            this.fullScreenRadioBtn.AutoSize = true;
            this.fullScreenRadioBtn.Location = new System.Drawing.Point(6, 21);
            this.fullScreenRadioBtn.Name = "fullScreenRadioBtn";
            this.fullScreenRadioBtn.Size = new System.Drawing.Size(71, 16);
            this.fullScreenRadioBtn.TabIndex = 0;
            this.fullScreenRadioBtn.Text = "전체화면";
            this.fullScreenRadioBtn.UseVisualStyleBackColor = true;
            this.fullScreenRadioBtn.Click += new System.EventHandler(this.fullScreenRadioBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userPathRadioBtn);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.desktopSaveRadioBtn);
            this.groupBox2.Controls.Add(this.clipboardRadioBtn);
            this.groupBox2.Location = new System.Drawing.Point(3, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 119);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "▶︎ 저장경로 설정";
            // 
            // userPathRadioBtn
            // 
            this.userPathRadioBtn.AutoSize = true;
            this.userPathRadioBtn.Location = new System.Drawing.Point(7, 65);
            this.userPathRadioBtn.Name = "userPathRadioBtn";
            this.userPathRadioBtn.Size = new System.Drawing.Size(87, 16);
            this.userPathRadioBtn.TabIndex = 0;
            this.userPathRadioBtn.Text = "사용자 지정";
            this.userPathRadioBtn.UseVisualStyleBackColor = true;
            this.userPathRadioBtn.Click += new System.EventHandler(this.userPathRadioBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.currentPathLabel);
            this.flowLayoutPanel1.Controls.Add(this.currentPathTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 84);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 29);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // currentPathLabel
            // 
            this.currentPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentPathLabel.AutoSize = true;
            this.currentPathLabel.Location = new System.Drawing.Point(3, 7);
            this.currentPathLabel.Margin = new System.Windows.Forms.Padding(3);
            this.currentPathLabel.Name = "currentPathLabel";
            this.currentPathLabel.Size = new System.Drawing.Size(85, 12);
            this.currentPathLabel.TabIndex = 0;
            this.currentPathLabel.Text = "→ 설정된 경로";
            // 
            // currentPathTextBox
            // 
            this.currentPathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentPathTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.currentPathTextBox.Location = new System.Drawing.Point(94, 3);
            this.currentPathTextBox.Name = "currentPathTextBox";
            this.currentPathTextBox.ReadOnly = true;
            this.currentPathTextBox.Size = new System.Drawing.Size(152, 21);
            this.currentPathTextBox.TabIndex = 1;
            this.currentPathTextBox.TabStop = false;
            this.currentPathTextBox.Text = "Clipboard";
            // 
            // desktopSaveRadioBtn
            // 
            this.desktopSaveRadioBtn.AutoSize = true;
            this.desktopSaveRadioBtn.Location = new System.Drawing.Point(7, 43);
            this.desktopSaveRadioBtn.Name = "desktopSaveRadioBtn";
            this.desktopSaveRadioBtn.Size = new System.Drawing.Size(71, 16);
            this.desktopSaveRadioBtn.TabIndex = 0;
            this.desktopSaveRadioBtn.Text = "바탕화면";
            this.desktopSaveRadioBtn.UseVisualStyleBackColor = true;
            this.desktopSaveRadioBtn.Click += new System.EventHandler(this.desktopSaveRadioBtn_Click);
            // 
            // clipboardRadioBtn
            // 
            this.clipboardRadioBtn.AutoSize = true;
            this.clipboardRadioBtn.Checked = true;
            this.clipboardRadioBtn.Location = new System.Drawing.Point(7, 21);
            this.clipboardRadioBtn.Name = "clipboardRadioBtn";
            this.clipboardRadioBtn.Size = new System.Drawing.Size(71, 16);
            this.clipboardRadioBtn.TabIndex = 0;
            this.clipboardRadioBtn.TabStop = true;
            this.clipboardRadioBtn.Text = "클립보드";
            this.clipboardRadioBtn.UseVisualStyleBackColor = true;
            this.clipboardRadioBtn.Click += new System.EventHandler(this.clipboardRadioBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(3, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 49);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "▶︎ 단축키";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.currentHotKeyTextBox);
            this.flowLayoutPanel2.Controls.Add(this.hoyKeyChangeButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 14);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(246, 29);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // currentHotKeyTextBox
            // 
            this.currentHotKeyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentHotKeyTextBox.Location = new System.Drawing.Point(3, 4);
            this.currentHotKeyTextBox.Name = "currentHotKeyTextBox";
            this.currentHotKeyTextBox.ReadOnly = true;
            this.currentHotKeyTextBox.Size = new System.Drawing.Size(192, 21);
            this.currentHotKeyTextBox.TabIndex = 1;
            this.currentHotKeyTextBox.TabStop = false;
            this.currentHotKeyTextBox.Text = "Ctrl + C";
            this.currentHotKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoyKeyChangeButton
            // 
            this.hoyKeyChangeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hoyKeyChangeButton.Location = new System.Drawing.Point(201, 3);
            this.hoyKeyChangeButton.Name = "hoyKeyChangeButton";
            this.hoyKeyChangeButton.Size = new System.Drawing.Size(42, 23);
            this.hoyKeyChangeButton.TabIndex = 2;
            this.hoyKeyChangeButton.TabStop = false;
            this.hoyKeyChangeButton.Text = "변경";
            this.hoyKeyChangeButton.UseVisualStyleBackColor = true;
            this.hoyKeyChangeButton.Click += new System.EventHandler(this.hoyKeyChangeButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabel1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(3, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 57);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "▶︎ Info";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(12, 6);
            this.linkLabel1.Location = new System.Drawing.Point(4, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 19);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Feedback -> GitHub";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "2019년 1학기 Applay 앱잼";
            // 
            // Capturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 366);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Capturer";
            this.Text = "Capturer";
            this.Load += new System.EventHandler(this.Capturer_Load);
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
    }
}

