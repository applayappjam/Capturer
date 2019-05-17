namespace Capturer
{
    partial class HotKeyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentHotKey = new System.Windows.Forms.TextBox();
            this.NewHotKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentHotKey
            // 
            this.currentHotKey.BackColor = System.Drawing.SystemColors.Control;
            this.currentHotKey.Location = new System.Drawing.Point(151, 25);
            this.currentHotKey.Name = "currentHotKey";
            this.currentHotKey.ReadOnly = true;
            this.currentHotKey.Size = new System.Drawing.Size(130, 25);
            this.currentHotKey.TabIndex = 0;
            this.currentHotKey.Text = "현재 단축키";
            this.currentHotKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewHotKey
            // 
            this.NewHotKey.BackColor = System.Drawing.SystemColors.Control;
            this.NewHotKey.Location = new System.Drawing.Point(151, 55);
            this.NewHotKey.Name = "NewHotKey";
            this.NewHotKey.ReadOnly = true;
            this.NewHotKey.Size = new System.Drawing.Size(130, 25);
            this.NewHotKey.TabIndex = 0;
            this.NewHotKey.Text = "변경할 단축키";
            this.NewHotKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewHotKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownHotKey);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재 단축키";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "변경할 단축키";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "변경";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChangeHotKey);
            // 
            // HotKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(293, 137);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewHotKey);
            this.Controls.Add(this.currentHotKey);
            this.Name = "HotKeyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HotKeyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentHotKey;
        private System.Windows.Forms.TextBox NewHotKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}