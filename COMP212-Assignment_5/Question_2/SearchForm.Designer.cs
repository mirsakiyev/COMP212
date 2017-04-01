namespace Question_2
{
    partial class SearchForm
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
            this.intTextBox = new System.Windows.Forms.TextBox();
            this.doubleTextBox = new System.Windows.Forms.TextBox();
            this.intLbl = new System.Windows.Forms.Label();
            this.doubleLbl = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.randomBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // intTextBox
            // 
            this.intTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.intTextBox.Location = new System.Drawing.Point(23, 95);
            this.intTextBox.Name = "intTextBox";
            this.intTextBox.ReadOnly = true;
            this.intTextBox.Size = new System.Drawing.Size(352, 22);
            this.intTextBox.TabIndex = 0;
            // 
            // doubleTextBox
            // 
            this.doubleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.doubleTextBox.Location = new System.Drawing.Point(23, 152);
            this.doubleTextBox.Name = "doubleTextBox";
            this.doubleTextBox.ReadOnly = true;
            this.doubleTextBox.Size = new System.Drawing.Size(352, 22);
            this.doubleTextBox.TabIndex = 1;
            // 
            // intLbl
            // 
            this.intLbl.AutoSize = true;
            this.intLbl.Location = new System.Drawing.Point(23, 72);
            this.intLbl.Name = "intLbl";
            this.intLbl.Size = new System.Drawing.Size(68, 17);
            this.intLbl.TabIndex = 2;
            this.intLbl.Text = "int values";
            // 
            // doubleLbl
            // 
            this.doubleLbl.AutoSize = true;
            this.doubleLbl.Location = new System.Drawing.Point(23, 129);
            this.doubleLbl.Name = "doubleLbl";
            this.doubleLbl.Size = new System.Drawing.Size(96, 17);
            this.doubleLbl.TabIndex = 3;
            this.doubleLbl.Text = "double values";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(23, 37);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(53, 22);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(23, 14);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(53, 17);
            this.searchLbl.TabIndex = 5;
            this.searchLbl.Text = "Search";
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(215, 37);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(75, 30);
            this.randomBtn.TabIndex = 6;
            this.randomBtn.Text = "Random";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(113, 37);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 30);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 215);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.doubleLbl);
            this.Controls.Add(this.intLbl);
            this.Controls.Add(this.doubleTextBox);
            this.Controls.Add(this.intTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox intTextBox;
        private System.Windows.Forms.TextBox doubleTextBox;
        private System.Windows.Forms.Label intLbl;
        private System.Windows.Forms.Label doubleLbl;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Button searchBtn;
    }
}

