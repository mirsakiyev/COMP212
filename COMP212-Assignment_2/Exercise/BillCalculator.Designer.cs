namespace Exercise
{
    partial class BillCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillCalculator));
            this.beverageListBox = new System.Windows.Forms.ListBox();
            this.beveragePriceListBox = new System.Windows.Forms.ListBox();
            this.beverageLbl = new System.Windows.Forms.Label();
            this.appetizerLbl = new System.Windows.Forms.Label();
            this.appetizerPriceListBox = new System.Windows.Forms.ListBox();
            this.appetizerListBox = new System.Windows.Forms.ListBox();
            this.mainCourseLbl = new System.Windows.Forms.Label();
            this.mainCoursePriceListBox = new System.Windows.Forms.ListBox();
            this.mainCourseListBox = new System.Windows.Forms.ListBox();
            this.desertLbl = new System.Windows.Forms.Label();
            this.dessertListBox = new System.Windows.Forms.ListBox();
            this.dessertPriceListBox = new System.Windows.Forms.ListBox();
            this.discardBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.yourBillLbl = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // beverageListBox
            // 
            this.beverageListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beverageListBox.FormattingEnabled = true;
            this.beverageListBox.ItemHeight = 17;
            this.beverageListBox.Items.AddRange(new object[] {
            "Soda",
            "Tea",
            "Coffee",
            "Mineral Water",
            "Juice",
            "Milk"});
            this.beverageListBox.Location = new System.Drawing.Point(86, 42);
            this.beverageListBox.Name = "beverageListBox";
            this.beverageListBox.Size = new System.Drawing.Size(122, 106);
            this.beverageListBox.TabIndex = 1;
            // 
            // beveragePriceListBox
            // 
            this.beveragePriceListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.beveragePriceListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beveragePriceListBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.beveragePriceListBox.FormattingEnabled = true;
            this.beveragePriceListBox.ItemHeight = 17;
            this.beveragePriceListBox.Items.AddRange(new object[] {
            "$1.95",
            "$1.50",
            "$1.25",
            "$2.95",
            "$2.50",
            "$1.50"});
            this.beveragePriceListBox.Location = new System.Drawing.Point(28, 43);
            this.beveragePriceListBox.Name = "beveragePriceListBox";
            this.beveragePriceListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.beveragePriceListBox.Size = new System.Drawing.Size(52, 106);
            this.beveragePriceListBox.TabIndex = 2;
            // 
            // beverageLbl
            // 
            this.beverageLbl.AutoSize = true;
            this.beverageLbl.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beverageLbl.Location = new System.Drawing.Point(81, 14);
            this.beverageLbl.Name = "beverageLbl";
            this.beverageLbl.Size = new System.Drawing.Size(93, 25);
            this.beverageLbl.TabIndex = 3;
            this.beverageLbl.Text = "Beverage";
            // 
            // appetizerLbl
            // 
            this.appetizerLbl.AutoSize = true;
            this.appetizerLbl.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appetizerLbl.Location = new System.Drawing.Point(314, 14);
            this.appetizerLbl.Name = "appetizerLbl";
            this.appetizerLbl.Size = new System.Drawing.Size(98, 25);
            this.appetizerLbl.TabIndex = 4;
            this.appetizerLbl.Text = "Appetizer";
            // 
            // appetizerPriceListBox
            // 
            this.appetizerPriceListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.appetizerPriceListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appetizerPriceListBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.appetizerPriceListBox.FormattingEnabled = true;
            this.appetizerPriceListBox.ItemHeight = 17;
            this.appetizerPriceListBox.Items.AddRange(new object[] {
            "$5.95",
            "$6.95",
            "$8.95",
            "$8.95",
            "$10.95",
            "$12.95",
            "$6.95"});
            this.appetizerPriceListBox.Location = new System.Drawing.Point(262, 43);
            this.appetizerPriceListBox.Name = "appetizerPriceListBox";
            this.appetizerPriceListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.appetizerPriceListBox.Size = new System.Drawing.Size(52, 123);
            this.appetizerPriceListBox.TabIndex = 5;
            // 
            // appetizerListBox
            // 
            this.appetizerListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appetizerListBox.FormattingEnabled = true;
            this.appetizerListBox.ItemHeight = 17;
            this.appetizerListBox.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Buffalo Fingers",
            "Potato Skins",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail",
            "Chips and Salsa"});
            this.appetizerListBox.Location = new System.Drawing.Point(320, 43);
            this.appetizerListBox.Name = "appetizerListBox";
            this.appetizerListBox.Size = new System.Drawing.Size(137, 123);
            this.appetizerListBox.TabIndex = 6;
            // 
            // mainCourseLbl
            // 
            this.mainCourseLbl.AutoSize = true;
            this.mainCourseLbl.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCourseLbl.Location = new System.Drawing.Point(81, 161);
            this.mainCourseLbl.Name = "mainCourseLbl";
            this.mainCourseLbl.Size = new System.Drawing.Size(127, 25);
            this.mainCourseLbl.TabIndex = 7;
            this.mainCourseLbl.Text = "Main Course";
            // 
            // mainCoursePriceListBox
            // 
            this.mainCoursePriceListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mainCoursePriceListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCoursePriceListBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.mainCoursePriceListBox.FormattingEnabled = true;
            this.mainCoursePriceListBox.ItemHeight = 17;
            this.mainCoursePriceListBox.Items.AddRange(new object[] {
            "$15.95",
            "$13.95",
            "$13.95",
            "$11.95",
            "$19.95",
            "$20.95",
            "$18.95",
            "$13.95",
            "$14.95"});
            this.mainCoursePriceListBox.Location = new System.Drawing.Point(28, 191);
            this.mainCoursePriceListBox.Name = "mainCoursePriceListBox";
            this.mainCoursePriceListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.mainCoursePriceListBox.Size = new System.Drawing.Size(52, 157);
            this.mainCoursePriceListBox.TabIndex = 8;
            // 
            // mainCourseListBox
            // 
            this.mainCourseListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCourseListBox.FormattingEnabled = true;
            this.mainCourseListBox.ItemHeight = 17;
            this.mainCourseListBox.Items.AddRange(new object[] {
            "Seafood Alfredo",
            "Chicken Alfedo",
            "Chicken Picatta",
            "Turkey Club",
            "Lobster Pie",
            "Prime Rib",
            "Shrimp Scampi",
            "Turkey Dinner",
            "Stuffed Chicken"});
            this.mainCourseListBox.Location = new System.Drawing.Point(86, 191);
            this.mainCourseListBox.Name = "mainCourseListBox";
            this.mainCourseListBox.Size = new System.Drawing.Size(122, 157);
            this.mainCourseListBox.TabIndex = 9;
            // 
            // desertLbl
            // 
            this.desertLbl.AutoSize = true;
            this.desertLbl.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desertLbl.Location = new System.Drawing.Point(325, 178);
            this.desertLbl.Name = "desertLbl";
            this.desertLbl.Size = new System.Drawing.Size(77, 25);
            this.desertLbl.TabIndex = 10;
            this.desertLbl.Text = "Dessert";
            // 
            // dessertListBox
            // 
            this.dessertListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertListBox.FormattingEnabled = true;
            this.dessertListBox.ItemHeight = 17;
            this.dessertListBox.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Pie",
            "Mud Pie",
            "Apple Crisp"});
            this.dessertListBox.Location = new System.Drawing.Point(320, 208);
            this.dessertListBox.Name = "dessertListBox";
            this.dessertListBox.Size = new System.Drawing.Size(137, 89);
            this.dessertListBox.TabIndex = 11;
            // 
            // dessertPriceListBox
            // 
            this.dessertPriceListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.dessertPriceListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertPriceListBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.dessertPriceListBox.FormattingEnabled = true;
            this.dessertPriceListBox.ItemHeight = 17;
            this.dessertPriceListBox.Items.AddRange(new object[] {
            "$5.95",
            "$3.95",
            "$5.95",
            "$4.95",
            "$5.95"});
            this.dessertPriceListBox.Location = new System.Drawing.Point(262, 208);
            this.dessertPriceListBox.Name = "dessertPriceListBox";
            this.dessertPriceListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.dessertPriceListBox.Size = new System.Drawing.Size(52, 89);
            this.dessertPriceListBox.TabIndex = 12;
            // 
            // discardBtn
            // 
            this.discardBtn.BackColor = System.Drawing.Color.MistyRose;
            this.discardBtn.Location = new System.Drawing.Point(262, 312);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(70, 37);
            this.discardBtn.TabIndex = 13;
            this.discardBtn.Text = "Discard";
            this.discardBtn.UseVisualStyleBackColor = false;
            this.discardBtn.Click += new System.EventHandler(this.discardBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.submitBtn.Location = new System.Drawing.Point(338, 312);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(119, 37);
            this.submitBtn.TabIndex = 14;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // billTextBox
            // 
            this.billTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTextBox.Location = new System.Drawing.Point(357, 373);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.ReadOnly = true;
            this.billTextBox.Size = new System.Drawing.Size(100, 30);
            this.billTextBox.TabIndex = 15;
            this.billTextBox.Text = "$0";
            // 
            // yourBillLbl
            // 
            this.yourBillLbl.AutoSize = true;
            this.yourBillLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourBillLbl.Location = new System.Drawing.Point(264, 376);
            this.yourBillLbl.Name = "yourBillLbl";
            this.yourBillLbl.Size = new System.Drawing.Size(87, 23);
            this.yourBillLbl.TabIndex = 16;
            this.yourBillLbl.Text = "Your Bill:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(486, 26);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(127, 21);
            this.toolStripStatusLbl.Text = "toolStripStatusLbl";
            // 
            // BillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.yourBillLbl);
            this.Controls.Add(this.billTextBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.discardBtn);
            this.Controls.Add(this.dessertPriceListBox);
            this.Controls.Add(this.dessertListBox);
            this.Controls.Add(this.desertLbl);
            this.Controls.Add(this.mainCourseListBox);
            this.Controls.Add(this.mainCoursePriceListBox);
            this.Controls.Add(this.mainCourseLbl);
            this.Controls.Add(this.appetizerListBox);
            this.Controls.Add(this.appetizerPriceListBox);
            this.Controls.Add(this.appetizerLbl);
            this.Controls.Add(this.beverageLbl);
            this.Controls.Add(this.beveragePriceListBox);
            this.Controls.Add(this.beverageListBox);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.BillCalculator_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox beverageListBox;
        private System.Windows.Forms.ListBox beveragePriceListBox;
        private System.Windows.Forms.Label beverageLbl;
        private System.Windows.Forms.Label appetizerLbl;
        private System.Windows.Forms.ListBox appetizerPriceListBox;
        private System.Windows.Forms.ListBox appetizerListBox;
        private System.Windows.Forms.Label mainCourseLbl;
        private System.Windows.Forms.ListBox mainCoursePriceListBox;
        private System.Windows.Forms.ListBox mainCourseListBox;
        private System.Windows.Forms.Label desertLbl;
        private System.Windows.Forms.ListBox dessertListBox;
        private System.Windows.Forms.ListBox dessertPriceListBox;
        private System.Windows.Forms.Button discardBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.Label yourBillLbl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
    }
}

