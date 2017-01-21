namespace COMP212_Assignment_1
{
    partial class pubNotForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.publishBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Content ";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(267, 56);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(237, 22);
            this.contentTextBox.TabIndex = 1;
            // 
            // publishBtn
            // 
            this.publishBtn.Location = new System.Drawing.Point(67, 136);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(108, 39);
            this.publishBtn.TabIndex = 2;
            this.publishBtn.Text = "Publish";
            this.publishBtn.UseVisualStyleBackColor = true;
            this.publishBtn.Click += new System.EventHandler(this.publishBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(267, 136);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(108, 39);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pubNotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 203);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.publishBtn);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.label1);
            this.Name = "pubNotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publish Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Button publishBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}