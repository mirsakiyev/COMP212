namespace COMP212_Assignment_1
{
    partial class manSubForm
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
            this.emailCheckB = new System.Windows.Forms.CheckBox();
            this.mobileCheckB = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.subscribeBtn = new System.Windows.Forms.Button();
            this.unsubscribeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.invalidEmailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailCheckB
            // 
            this.emailCheckB.AutoSize = true;
            this.emailCheckB.Location = new System.Drawing.Point(78, 34);
            this.emailCheckB.Name = "emailCheckB";
            this.emailCheckB.Size = new System.Drawing.Size(181, 21);
            this.emailCheckB.TabIndex = 0;
            this.emailCheckB.Text = "Message Sent by Email ";
            this.emailCheckB.UseVisualStyleBackColor = true;
            this.emailCheckB.CheckedChanged += new System.EventHandler(this.emailCheckB_CheckedChanged);
            // 
            // mobileCheckB
            // 
            this.mobileCheckB.AutoSize = true;
            this.mobileCheckB.Location = new System.Drawing.Point(78, 90);
            this.mobileCheckB.Name = "mobileCheckB";
            this.mobileCheckB.Size = new System.Drawing.Size(184, 21);
            this.mobileCheckB.TabIndex = 1;
            this.mobileCheckB.Text = "Message Sent by Mobile";
            this.mobileCheckB.UseVisualStyleBackColor = true;
            this.mobileCheckB.CheckedChanged += new System.EventHandler(this.mobileCheckB_CheckedChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(298, 32);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(199, 22);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Enabled = false;
            this.mobileTextBox.Location = new System.Drawing.Point(298, 89);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(199, 22);
            this.mobileTextBox.TabIndex = 3;
            // 
            // subscribeBtn
            // 
            this.subscribeBtn.Location = new System.Drawing.Point(78, 144);
            this.subscribeBtn.Name = "subscribeBtn";
            this.subscribeBtn.Size = new System.Drawing.Size(108, 36);
            this.subscribeBtn.TabIndex = 4;
            this.subscribeBtn.Text = "Subscribe";
            this.subscribeBtn.UseVisualStyleBackColor = true;
            this.subscribeBtn.Click += new System.EventHandler(this.subscribeBtn_Click);
            // 
            // unsubscribeBtn
            // 
            this.unsubscribeBtn.Location = new System.Drawing.Point(233, 144);
            this.unsubscribeBtn.Name = "unsubscribeBtn";
            this.unsubscribeBtn.Size = new System.Drawing.Size(108, 36);
            this.unsubscribeBtn.TabIndex = 5;
            this.unsubscribeBtn.Text = "Unsubscribe";
            this.unsubscribeBtn.UseVisualStyleBackColor = true;
            this.unsubscribeBtn.Click += new System.EventHandler(this.unsubscribeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(389, 144);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(108, 36);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // invalidEmailLabel
            // 
            this.invalidEmailLabel.AutoSize = true;
            this.invalidEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidEmailLabel.Location = new System.Drawing.Point(298, 58);
            this.invalidEmailLabel.Name = "invalidEmailLabel";
            this.invalidEmailLabel.Size = new System.Drawing.Size(0, 17);
            this.invalidEmailLabel.TabIndex = 7;
            this.invalidEmailLabel.Visible = false;
            // 
            // manSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 203);
            this.Controls.Add(this.invalidEmailLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.unsubscribeBtn);
            this.Controls.Add(this.subscribeBtn);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.mobileCheckB);
            this.Controls.Add(this.emailCheckB);
            this.Name = "manSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox emailCheckB;
        private System.Windows.Forms.CheckBox mobileCheckB;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Button subscribeBtn;
        private System.Windows.Forms.Button unsubscribeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label invalidEmailLabel;
    }
}