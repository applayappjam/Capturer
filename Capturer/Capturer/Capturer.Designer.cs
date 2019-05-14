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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentHoyKeyLabel = new System.Windows.Forms.Label();
            this.currentHotKeyTextBox = new System.Windows.Forms.TextBox();
            this.hoyKeyChangeButton = new System.Windows.Forms.Button();
            this.captureModeLabel = new System.Windows.Forms.Label();
            this.pathSettingLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentPathLabel = new System.Windows.Forms.Label();
            this.currentPathTextBox = new System.Windows.Forms.TextBox();
            this.hotKeyLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dragRadioBtn = new System.Windows.Forms.RadioButton();
            this.programRadioBtn = new System.Windows.Forms.RadioButton();
            this.fullScreenRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userPathRadioBtn = new System.Windows.Forms.RadioButton();
            this.desktopSaveRadioBtn = new System.Windows.Forms.RadioButton();
            this.clipboardRadioBtn = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel2, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.captureModeLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pathSettingLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.hotKeyLabel, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.contactLabel, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.contentLabel, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.groupBox2, 0, 4);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(260, 339);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.currentHoyKeyLabel);
            this.flowLayoutPanel2.Controls.Add(this.currentHotKeyTextBox);
            this.flowLayoutPanel2.Controls.Add(this.hoyKeyChangeButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 248);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(255, 29);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // currentHoyKeyLabel
            // 
            this.currentHoyKeyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentHoyKeyLabel.AutoSize = true;
            this.currentHoyKeyLabel.Location = new System.Drawing.Point(3, 8);
            this.currentHoyKeyLabel.Margin = new System.Windows.Forms.Padding(3);
            this.currentHoyKeyLabel.Name = "currentHoyKeyLabel";
            this.currentHoyKeyLabel.Size = new System.Drawing.Size(85, 12);
            this.currentHoyKeyLabel.TabIndex = 0;
            this.currentHoyKeyLabel.Text = "ㅇ 현재 단축키";
            // 
            // currentHotKeyTextBox
            // 
            this.currentHotKeyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentHotKeyTextBox.Location = new System.Drawing.Point(94, 4);
            this.currentHotKeyTextBox.Name = "currentHotKeyTextBox";
            this.currentHotKeyTextBox.Size = new System.Drawing.Size(111, 21);
            this.currentHotKeyTextBox.TabIndex = 1;
            // 
            // hoyKeyChangeButton
            // 
            this.hoyKeyChangeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hoyKeyChangeButton.Location = new System.Drawing.Point(211, 3);
            this.hoyKeyChangeButton.Name = "hoyKeyChangeButton";
            this.hoyKeyChangeButton.Size = new System.Drawing.Size(37, 23);
            this.hoyKeyChangeButton.TabIndex = 2;
            this.hoyKeyChangeButton.Text = "변경";
            this.hoyKeyChangeButton.UseVisualStyleBackColor = true;
            this.hoyKeyChangeButton.Click += new System.EventHandler(this.hoyKeyChangeButton_Click);
            // 
            // captureModeLabel
            // 
            this.captureModeLabel.AutoSize = true;
            this.captureModeLabel.Location = new System.Drawing.Point(3, 3);
            this.captureModeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.captureModeLabel.Name = "captureModeLabel";
            this.captureModeLabel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.captureModeLabel.Size = new System.Drawing.Size(69, 14);
            this.captureModeLabel.TabIndex = 0;
            this.captureModeLabel.Text = "> 촬영 모드";
            // 
            // pathSettingLabel
            // 
            this.pathSettingLabel.AutoSize = true;
            this.pathSettingLabel.Location = new System.Drawing.Point(3, 98);
            this.pathSettingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.pathSettingLabel.Name = "pathSettingLabel";
            this.pathSettingLabel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.pathSettingLabel.Size = new System.Drawing.Size(69, 14);
            this.pathSettingLabel.TabIndex = 2;
            this.pathSettingLabel.Text = "> 경로 설정";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.currentPathLabel);
            this.flowLayoutPanel1.Controls.Add(this.currentPathTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 29);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // currentPathLabel
            // 
            this.currentPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentPathLabel.AutoSize = true;
            this.currentPathLabel.Location = new System.Drawing.Point(3, 7);
            this.currentPathLabel.Margin = new System.Windows.Forms.Padding(3);
            this.currentPathLabel.Name = "currentPathLabel";
            this.currentPathLabel.Size = new System.Drawing.Size(73, 12);
            this.currentPathLabel.TabIndex = 0;
            this.currentPathLabel.Text = "ㅇ 현재 경로";
            // 
            // currentPathTextBox
            // 
            this.currentPathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentPathTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.currentPathTextBox.Location = new System.Drawing.Point(82, 3);
            this.currentPathTextBox.Name = "currentPathTextBox";
            this.currentPathTextBox.Size = new System.Drawing.Size(148, 21);
            this.currentPathTextBox.TabIndex = 1;
            // 
            // hotKeyLabel
            // 
            this.hotKeyLabel.AutoSize = true;
            this.hotKeyLabel.Location = new System.Drawing.Point(3, 228);
            this.hotKeyLabel.Margin = new System.Windows.Forms.Padding(3);
            this.hotKeyLabel.Name = "hotKeyLabel";
            this.hotKeyLabel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.hotKeyLabel.Size = new System.Drawing.Size(53, 14);
            this.hotKeyLabel.TabIndex = 5;
            this.hotKeyLabel.Text = "> 단축키";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(3, 283);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(3);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.contactLabel.Size = new System.Drawing.Size(60, 14);
            this.contactLabel.TabIndex = 7;
            this.contactLabel.Text = "> Contact";
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(3, 303);
            this.contentLabel.Margin = new System.Windows.Forms.Padding(3);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(65, 12);
            this.contentLabel.TabIndex = 8;
            this.contentLabel.Text = "github_site";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dragRadioBtn);
            this.groupBox1.Controls.Add(this.programRadioBtn);
            this.groupBox1.Controls.Add(this.fullScreenRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "group1";
            // 
            // dragRadioBtn
            // 
            this.dragRadioBtn.AutoSize = true;
            this.dragRadioBtn.Location = new System.Drawing.Point(112, 21);
            this.dragRadioBtn.Name = "dragRadioBtn";
            this.dragRadioBtn.Size = new System.Drawing.Size(46, 16);
            this.dragRadioBtn.TabIndex = 2;
            this.dragRadioBtn.TabStop = true;
            this.dragRadioBtn.Text = "btn3";
            this.dragRadioBtn.UseVisualStyleBackColor = true;
            // 
            // programRadioBtn
            // 
            this.programRadioBtn.AutoSize = true;
            this.programRadioBtn.Location = new System.Drawing.Point(59, 21);
            this.programRadioBtn.Name = "programRadioBtn";
            this.programRadioBtn.Size = new System.Drawing.Size(46, 16);
            this.programRadioBtn.TabIndex = 1;
            this.programRadioBtn.TabStop = true;
            this.programRadioBtn.Text = "btn2";
            this.programRadioBtn.UseVisualStyleBackColor = true;
            // 
            // fullScreenRadioBtn
            // 
            this.fullScreenRadioBtn.AutoSize = true;
            this.fullScreenRadioBtn.Location = new System.Drawing.Point(7, 21);
            this.fullScreenRadioBtn.Name = "fullScreenRadioBtn";
            this.fullScreenRadioBtn.Size = new System.Drawing.Size(46, 16);
            this.fullScreenRadioBtn.TabIndex = 0;
            this.fullScreenRadioBtn.TabStop = true;
            this.fullScreenRadioBtn.Text = "btn1";
            this.fullScreenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userPathRadioBtn);
            this.groupBox2.Controls.Add(this.desktopSaveRadioBtn);
            this.groupBox2.Controls.Add(this.clipboardRadioBtn);
            this.groupBox2.Location = new System.Drawing.Point(3, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 69);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "group2";
            // 
            // userPathRadioBtn
            // 
            this.userPathRadioBtn.AutoSize = true;
            this.userPathRadioBtn.Location = new System.Drawing.Point(111, 21);
            this.userPathRadioBtn.Name = "userPathRadioBtn";
            this.userPathRadioBtn.Size = new System.Drawing.Size(46, 16);
            this.userPathRadioBtn.TabIndex = 0;
            this.userPathRadioBtn.TabStop = true;
            this.userPathRadioBtn.Text = "btn6";
            this.userPathRadioBtn.UseVisualStyleBackColor = true;
            // 
            // desktopSaveRadioBtn
            // 
            this.desktopSaveRadioBtn.AutoSize = true;
            this.desktopSaveRadioBtn.Location = new System.Drawing.Point(59, 21);
            this.desktopSaveRadioBtn.Name = "desktopSaveRadioBtn";
            this.desktopSaveRadioBtn.Size = new System.Drawing.Size(46, 16);
            this.desktopSaveRadioBtn.TabIndex = 0;
            this.desktopSaveRadioBtn.TabStop = true;
            this.desktopSaveRadioBtn.Text = "btn5";
            this.desktopSaveRadioBtn.UseVisualStyleBackColor = true;
            // 
            // clipboardRadioBtn
            // 
            this.clipboardRadioBtn.AutoSize = true;
            this.clipboardRadioBtn.Location = new System.Drawing.Point(7, 21);
            this.clipboardRadioBtn.Name = "clipboardRadioBtn";
            this.clipboardRadioBtn.Size = new System.Drawing.Size(46, 16);
            this.clipboardRadioBtn.TabIndex = 0;
            this.clipboardRadioBtn.TabStop = true;
            this.clipboardRadioBtn.Text = "btn4";
            this.clipboardRadioBtn.UseVisualStyleBackColor = true;
            // 
            // Capturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 363);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Capturer";
            this.Text = "Capturer";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label captureModeLabel;
        private System.Windows.Forms.Label pathSettingLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label currentPathLabel;
        private System.Windows.Forms.TextBox currentPathTextBox;
        private System.Windows.Forms.Label hotKeyLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label currentHoyKeyLabel;
        private System.Windows.Forms.TextBox currentHotKeyTextBox;
        private System.Windows.Forms.Button hoyKeyChangeButton;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton programRadioBtn;
        private System.Windows.Forms.RadioButton fullScreenRadioBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton dragRadioBtn;
        private System.Windows.Forms.RadioButton userPathRadioBtn;
        private System.Windows.Forms.RadioButton desktopSaveRadioBtn;
        private System.Windows.Forms.RadioButton clipboardRadioBtn;
    }
}

