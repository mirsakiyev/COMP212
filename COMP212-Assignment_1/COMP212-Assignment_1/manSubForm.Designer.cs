﻿namespace COMP212_Assignment_1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailCheckB
            // 
            this.emailCheckB.AutoSize = true;
            this.emailCheckB.Location = new System.Drawing.Point(47, 36);
            this.emailCheckB.Name = "emailCheckB";
            this.emailCheckB.Size = new System.Drawing.Size(181, 21);
            this.emailCheckB.TabIndex = 0;
            this.emailCheckB.Text = "Message Sent by Email ";
            this.emailCheckB.UseVisualStyleBackColor = true;
            // 
            // mobileCheckB
            // 
            this.mobileCheckB.AutoSize = true;
            this.mobileCheckB.Location = new System.Drawing.Point(47, 84);
            this.mobileCheckB.Name = "mobileCheckB";
            this.mobileCheckB.Size = new System.Drawing.Size(184, 21);
            this.mobileCheckB.TabIndex = 1;
            this.mobileCheckB.Text = "Message Sent by Mobile";
            this.mobileCheckB.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(316, 36);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(160, 22);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(316, 84);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(160, 22);
            this.mobileTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(401, 159);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // manSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 210);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.mobileCheckB);
            this.Controls.Add(this.emailCheckB);
            this.Name = "manSubForm";
            this.Text = "Manage Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox emailCheckB;
        private System.Windows.Forms.CheckBox mobileCheckB;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cancelBtn;
    }
}