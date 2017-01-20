namespace COMP212_Assignment_1
{
    partial class notManagerForm
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
            this.manSubBtn = new System.Windows.Forms.Button();
            this.pubNotBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manSubBtn
            // 
            this.manSubBtn.Location = new System.Drawing.Point(29, 82);
            this.manSubBtn.Name = "manSubBtn";
            this.manSubBtn.Size = new System.Drawing.Size(181, 43);
            this.manSubBtn.TabIndex = 1;
            this.manSubBtn.Text = "Manage Subscription";
            this.manSubBtn.UseVisualStyleBackColor = true;
            this.manSubBtn.Click += new System.EventHandler(this.manSubBtn_Click);
            // 
            // pubNotBtn
            // 
            this.pubNotBtn.Location = new System.Drawing.Point(240, 82);
            this.pubNotBtn.Name = "pubNotBtn";
            this.pubNotBtn.Size = new System.Drawing.Size(181, 43);
            this.pubNotBtn.TabIndex = 2;
            this.pubNotBtn.Text = "Publish Notification";
            this.pubNotBtn.UseVisualStyleBackColor = true;
            this.pubNotBtn.Click += new System.EventHandler(this.pubNotBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(453, 82);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(102, 43);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // notManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 203);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pubNotBtn);
            this.Controls.Add(this.manSubBtn);
            this.Name = "notManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manSubBtn;
        private System.Windows.Forms.Button pubNotBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

