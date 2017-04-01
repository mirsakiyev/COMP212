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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // intTextBox
            // 
            this.intTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.intTextBox.Location = new System.Drawing.Point(29, 106);
            this.intTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.intTextBox.Name = "intTextBox";
            this.intTextBox.ReadOnly = true;
            this.intTextBox.Size = new System.Drawing.Size(311, 27);
            this.intTextBox.TabIndex = 0;
            // 
            // doubleTextBox
            // 
            this.doubleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.doubleTextBox.Location = new System.Drawing.Point(29, 170);
            this.doubleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doubleTextBox.Name = "doubleTextBox";
            this.doubleTextBox.ReadOnly = true;
            this.doubleTextBox.Size = new System.Drawing.Size(311, 27);
            this.doubleTextBox.TabIndex = 1;
            // 
            // intLbl
            // 
            this.intLbl.AutoSize = true;
            this.intLbl.Location = new System.Drawing.Point(29, 82);
            this.intLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intLbl.Name = "intLbl";
            this.intLbl.Size = new System.Drawing.Size(80, 20);
            this.intLbl.TabIndex = 2;
            this.intLbl.Text = "int values";
            // 
            // doubleLbl
            // 
            this.doubleLbl.AutoSize = true;
            this.doubleLbl.Location = new System.Drawing.Point(29, 146);
            this.doubleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doubleLbl.Name = "doubleLbl";
            this.doubleLbl.Size = new System.Drawing.Size(111, 20);
            this.doubleLbl.TabIndex = 3;
            this.doubleLbl.Text = "double values";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(29, 46);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(65, 27);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(29, 22);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(62, 20);
            this.searchLbl.TabIndex = 5;
            this.searchLbl.Text = "Search";
            // 
            // randomBtn
            // 
            this.randomBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.randomBtn.Location = new System.Drawing.Point(246, 46);
            this.randomBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(94, 27);
            this.randomBtn.TabIndex = 6;
            this.randomBtn.Text = "Random";
            this.randomBtn.UseVisualStyleBackColor = false;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.Info;
            this.searchBtn.Location = new System.Drawing.Point(126, 46);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 27);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 236);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(374, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(0, 19);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 258);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.doubleLbl);
            this.Controls.Add(this.intLbl);
            this.Controls.Add(this.doubleTextBox);
            this.Controls.Add(this.intTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question 2";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip;
    }
}

