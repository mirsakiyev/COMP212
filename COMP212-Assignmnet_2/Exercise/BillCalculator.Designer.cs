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
            this.desertListBox = new System.Windows.Forms.ListBox();
            this.desertPriceListBox = new System.Windows.Forms.ListBox();
            this.discardBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beverageListBox
            // 
            this.beverageListBox.FormattingEnabled = true;
            this.beverageListBox.ItemHeight = 16;
            this.beverageListBox.Items.AddRange(new object[] {
            "Soda",
            "Tea",
            "Coffee",
            "Mineral Water",
            "Juice",
            "Milk"});
            this.beverageListBox.Location = new System.Drawing.Point(70, 32);
            this.beverageListBox.Name = "beverageListBox";
            this.beverageListBox.Size = new System.Drawing.Size(138, 100);
            this.beverageListBox.TabIndex = 1;
            // 
            // beveragePriceListBox
            // 
            this.beveragePriceListBox.Enabled = false;
            this.beveragePriceListBox.FormattingEnabled = true;
            this.beveragePriceListBox.ItemHeight = 16;
            this.beveragePriceListBox.Items.AddRange(new object[] {
            "$1.95",
            "$1.50",
            "$1.25",
            "$2.95",
            "$2.50",
            "$1.50"});
            this.beveragePriceListBox.Location = new System.Drawing.Point(12, 32);
            this.beveragePriceListBox.Name = "beveragePriceListBox";
            this.beveragePriceListBox.Size = new System.Drawing.Size(52, 100);
            this.beveragePriceListBox.TabIndex = 2;
            // 
            // beverageLbl
            // 
            this.beverageLbl.AutoSize = true;
            this.beverageLbl.Location = new System.Drawing.Point(53, 12);
            this.beverageLbl.Name = "beverageLbl";
            this.beverageLbl.Size = new System.Drawing.Size(69, 17);
            this.beverageLbl.TabIndex = 3;
            this.beverageLbl.Text = "Beverage";
            // 
            // appetizerLbl
            // 
            this.appetizerLbl.AutoSize = true;
            this.appetizerLbl.Location = new System.Drawing.Point(279, 12);
            this.appetizerLbl.Name = "appetizerLbl";
            this.appetizerLbl.Size = new System.Drawing.Size(68, 17);
            this.appetizerLbl.TabIndex = 4;
            this.appetizerLbl.Text = "Appetizer";
            // 
            // appetizerPriceListBox
            // 
            this.appetizerPriceListBox.Enabled = false;
            this.appetizerPriceListBox.FormattingEnabled = true;
            this.appetizerPriceListBox.ItemHeight = 16;
            this.appetizerPriceListBox.Items.AddRange(new object[] {
            "$5.95",
            "$6.95",
            "$8.95",
            "$8.95",
            "$10.95",
            "$12.95",
            "$6.95"});
            this.appetizerPriceListBox.Location = new System.Drawing.Point(256, 32);
            this.appetizerPriceListBox.Name = "appetizerPriceListBox";
            this.appetizerPriceListBox.Size = new System.Drawing.Size(52, 116);
            this.appetizerPriceListBox.TabIndex = 5;
            // 
            // appetizerListBox
            // 
            this.appetizerListBox.FormattingEnabled = true;
            this.appetizerListBox.ItemHeight = 16;
            this.appetizerListBox.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Buffalo Fingers",
            "Potato Skins",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail",
            "Chips and Salsa"});
            this.appetizerListBox.Location = new System.Drawing.Point(314, 32);
            this.appetizerListBox.Name = "appetizerListBox";
            this.appetizerListBox.Size = new System.Drawing.Size(138, 116);
            this.appetizerListBox.TabIndex = 6;
            // 
            // mainCourseLbl
            // 
            this.mainCourseLbl.AutoSize = true;
            this.mainCourseLbl.Location = new System.Drawing.Point(53, 162);
            this.mainCourseLbl.Name = "mainCourseLbl";
            this.mainCourseLbl.Size = new System.Drawing.Size(87, 17);
            this.mainCourseLbl.TabIndex = 7;
            this.mainCourseLbl.Text = "Main Course";
            // 
            // mainCoursePriceListBox
            // 
            this.mainCoursePriceListBox.Enabled = false;
            this.mainCoursePriceListBox.FormattingEnabled = true;
            this.mainCoursePriceListBox.ItemHeight = 16;
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
            this.mainCoursePriceListBox.Location = new System.Drawing.Point(12, 183);
            this.mainCoursePriceListBox.Name = "mainCoursePriceListBox";
            this.mainCoursePriceListBox.Size = new System.Drawing.Size(52, 148);
            this.mainCoursePriceListBox.TabIndex = 8;
            // 
            // mainCourseListBox
            // 
            this.mainCourseListBox.FormattingEnabled = true;
            this.mainCourseListBox.ItemHeight = 16;
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
            this.mainCourseListBox.Location = new System.Drawing.Point(70, 183);
            this.mainCourseListBox.Name = "mainCourseListBox";
            this.mainCourseListBox.Size = new System.Drawing.Size(138, 148);
            this.mainCourseListBox.TabIndex = 9;
            // 
            // desertLbl
            // 
            this.desertLbl.AutoSize = true;
            this.desertLbl.Location = new System.Drawing.Point(279, 162);
            this.desertLbl.Name = "desertLbl";
            this.desertLbl.Size = new System.Drawing.Size(50, 17);
            this.desertLbl.TabIndex = 10;
            this.desertLbl.Text = "Desert";
            // 
            // desertListBox
            // 
            this.desertListBox.FormattingEnabled = true;
            this.desertListBox.ItemHeight = 16;
            this.desertListBox.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Pie",
            "Mud Pie",
            "Apple Crisp"});
            this.desertListBox.Location = new System.Drawing.Point(314, 183);
            this.desertListBox.Name = "desertListBox";
            this.desertListBox.Size = new System.Drawing.Size(138, 84);
            this.desertListBox.TabIndex = 11;
            // 
            // desertPriceListBox
            // 
            this.desertPriceListBox.Enabled = false;
            this.desertPriceListBox.FormattingEnabled = true;
            this.desertPriceListBox.ItemHeight = 16;
            this.desertPriceListBox.Items.AddRange(new object[] {
            "$5.95",
            "$3.95",
            "$5.95",
            "$4.95",
            "$5.95"});
            this.desertPriceListBox.Location = new System.Drawing.Point(256, 183);
            this.desertPriceListBox.Name = "desertPriceListBox";
            this.desertPriceListBox.Size = new System.Drawing.Size(52, 84);
            this.desertPriceListBox.TabIndex = 12;
            // 
            // discardBtn
            // 
            this.discardBtn.Location = new System.Drawing.Point(256, 296);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(75, 34);
            this.discardBtn.TabIndex = 13;
            this.discardBtn.Text = "Discard";
            this.discardBtn.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(348, 296);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(104, 34);
            this.submitBtn.TabIndex = 14;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // BillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 399);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.discardBtn);
            this.Controls.Add(this.desertPriceListBox);
            this.Controls.Add(this.desertListBox);
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
            this.Name = "BillCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Bill Calculator";
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
        private System.Windows.Forms.ListBox desertListBox;
        private System.Windows.Forms.ListBox desertPriceListBox;
        private System.Windows.Forms.Button discardBtn;
        private System.Windows.Forms.Button submitBtn;
    }
}

