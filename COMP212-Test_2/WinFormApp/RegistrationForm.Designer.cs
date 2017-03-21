namespace WinFormApp
{
    partial class RegistrationForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.idLbl = new System.Windows.Forms.Label();
            this.courseLbl = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.coursesComboBox = new System.Windows.Forms.ComboBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(599, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(76, 76);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(74, 17);
            this.idLbl.TabIndex = 1;
            this.idLbl.Text = "Student ID";
            // 
            // courseLbl
            // 
            this.courseLbl.AutoSize = true;
            this.courseLbl.Location = new System.Drawing.Point(76, 123);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(53, 17);
            this.courseLbl.TabIndex = 2;
            this.courseLbl.Text = "Course";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(223, 70);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(236, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // coursesComboBox
            // 
            this.coursesComboBox.FormattingEnabled = true;
            this.coursesComboBox.Location = new System.Drawing.Point(220, 114);
            this.coursesComboBox.Name = "coursesComboBox";
            this.coursesComboBox.Size = new System.Drawing.Size(239, 24);
            this.coursesComboBox.TabIndex = 4;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(374, 192);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(85, 34);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(223, 192);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 33);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 379);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.coursesComboBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.courseLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.statusStrip1);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Registration";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox coursesComboBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button backBtn;
    }
}