namespace Exercise_1
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
            this.beverageLbl = new System.Windows.Forms.Label();
            this.appetizerLbl = new System.Windows.Forms.Label();
            this.mainCourseLbl = new System.Windows.Forms.Label();
            this.desertLbl = new System.Windows.Forms.Label();
            this.beverageComboBox = new System.Windows.Forms.ComboBox();
            this.appetizerComboBox = new System.Windows.Forms.ComboBox();
            this.mainCourseComboBox = new System.Windows.Forms.ComboBox();
            this.dessertComboBox = new System.Windows.Forms.ComboBox();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.discardBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.titleOrderListBox = new System.Windows.Forms.ListBox();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.yourOrderLbl = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.calcBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // beverageLbl
            // 
            this.beverageLbl.AutoSize = true;
            this.beverageLbl.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beverageLbl.Location = new System.Drawing.Point(21, 9);
            this.beverageLbl.Name = "beverageLbl";
            this.beverageLbl.Size = new System.Drawing.Size(93, 25);
            this.beverageLbl.TabIndex = 4;
            this.beverageLbl.Text = "Beverage";
            // 
            // appetizerLbl
            // 
            this.appetizerLbl.AutoSize = true;
            this.appetizerLbl.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appetizerLbl.Location = new System.Drawing.Point(16, 80);
            this.appetizerLbl.Name = "appetizerLbl";
            this.appetizerLbl.Size = new System.Drawing.Size(98, 25);
            this.appetizerLbl.TabIndex = 5;
            this.appetizerLbl.Text = "Appetizer";
            // 
            // mainCourseLbl
            // 
            this.mainCourseLbl.AutoSize = true;
            this.mainCourseLbl.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCourseLbl.Location = new System.Drawing.Point(16, 153);
            this.mainCourseLbl.Name = "mainCourseLbl";
            this.mainCourseLbl.Size = new System.Drawing.Size(127, 25);
            this.mainCourseLbl.TabIndex = 8;
            this.mainCourseLbl.Text = "Main Course";
            // 
            // desertLbl
            // 
            this.desertLbl.AutoSize = true;
            this.desertLbl.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desertLbl.Location = new System.Drawing.Point(21, 228);
            this.desertLbl.Name = "desertLbl";
            this.desertLbl.Size = new System.Drawing.Size(77, 25);
            this.desertLbl.TabIndex = 11;
            this.desertLbl.Text = "Dessert";
            // 
            // beverageComboBox
            // 
            this.beverageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beverageComboBox.FormattingEnabled = true;
            this.beverageComboBox.Items.AddRange(new object[] {
            "Soda",
            "Tea",
            "Coffee",
            "Mineral Water",
            "Juice",
            "Milk"});
            this.beverageComboBox.Location = new System.Drawing.Point(20, 36);
            this.beverageComboBox.Name = "beverageComboBox";
            this.beverageComboBox.Size = new System.Drawing.Size(170, 28);
            this.beverageComboBox.TabIndex = 12;
            // 
            // appetizerComboBox
            // 
            this.appetizerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appetizerComboBox.FormattingEnabled = true;
            this.appetizerComboBox.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Buffalo Fingers",
            "Potato Skins",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail",
            "Chips and Salsa"});
            this.appetizerComboBox.Location = new System.Drawing.Point(21, 108);
            this.appetizerComboBox.Name = "appetizerComboBox";
            this.appetizerComboBox.Size = new System.Drawing.Size(170, 28);
            this.appetizerComboBox.TabIndex = 13;
            // 
            // mainCourseComboBox
            // 
            this.mainCourseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCourseComboBox.FormattingEnabled = true;
            this.mainCourseComboBox.Items.AddRange(new object[] {
            "Seafood Alfredo",
            "Chicken Alfedo",
            "Chicken Picatta",
            "Turkey Club",
            "Lobster Pie",
            "Prime Rib",
            "Shrimp Scampi",
            "Turkey Dinner",
            "Stuffed Chicken"});
            this.mainCourseComboBox.Location = new System.Drawing.Point(20, 181);
            this.mainCourseComboBox.Name = "mainCourseComboBox";
            this.mainCourseComboBox.Size = new System.Drawing.Size(170, 28);
            this.mainCourseComboBox.TabIndex = 14;
            // 
            // dessertComboBox
            // 
            this.dessertComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertComboBox.FormattingEnabled = true;
            this.dessertComboBox.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Pie",
            "Mud Pie",
            "Apple Crisp"});
            this.dessertComboBox.Location = new System.Drawing.Point(21, 256);
            this.dessertComboBox.Name = "dessertComboBox";
            this.dessertComboBox.Size = new System.Drawing.Size(170, 28);
            this.dessertComboBox.TabIndex = 15;
            // 
            // orderListBox
            // 
            this.orderListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 20;
            this.orderListBox.Location = new System.Drawing.Point(215, 37);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(90, 324);
            this.orderListBox.TabIndex = 16;
            // 
            // discardBtn
            // 
            this.discardBtn.BackColor = System.Drawing.Color.LightCoral;
            this.discardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.discardBtn.Location = new System.Drawing.Point(21, 367);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(169, 36);
            this.discardBtn.TabIndex = 18;
            this.discardBtn.Text = "Discard";
            this.discardBtn.UseVisualStyleBackColor = false;
            this.discardBtn.Click += new System.EventHandler(this.discardBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(20, 315);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(170, 46);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // titleOrderListBox
            // 
            this.titleOrderListBox.BackColor = System.Drawing.SystemColors.Info;
            this.titleOrderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleOrderListBox.FormattingEnabled = true;
            this.titleOrderListBox.ItemHeight = 20;
            this.titleOrderListBox.Location = new System.Drawing.Point(311, 37);
            this.titleOrderListBox.Name = "titleOrderListBox";
            this.titleOrderListBox.Size = new System.Drawing.Size(195, 324);
            this.titleOrderListBox.TabIndex = 21;
            // 
            // billTextBox
            // 
            this.billTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.billTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTextBox.Location = new System.Drawing.Point(215, 369);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.ReadOnly = true;
            this.billTextBox.Size = new System.Drawing.Size(125, 34);
            this.billTextBox.TabIndex = 22;
            // 
            // yourOrderLbl
            // 
            this.yourOrderLbl.AutoSize = true;
            this.yourOrderLbl.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourOrderLbl.Location = new System.Drawing.Point(210, 9);
            this.yourOrderLbl.Name = "yourOrderLbl";
            this.yourOrderLbl.Size = new System.Drawing.Size(112, 25);
            this.yourOrderLbl.TabIndex = 23;
            this.yourOrderLbl.Text = "Your Order";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(539, 26);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 21);
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.Location = new System.Drawing.Point(346, 367);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(160, 40);
            this.calcBtn.TabIndex = 25;
            this.calcBtn.Text = "Calculate bill";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // BillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 449);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.yourOrderLbl);
            this.Controls.Add(this.billTextBox);
            this.Controls.Add(this.titleOrderListBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.discardBtn);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.dessertComboBox);
            this.Controls.Add(this.mainCourseComboBox);
            this.Controls.Add(this.appetizerComboBox);
            this.Controls.Add(this.beverageComboBox);
            this.Controls.Add(this.desertLbl);
            this.Controls.Add(this.mainCourseLbl);
            this.Controls.Add(this.appetizerLbl);
            this.Controls.Add(this.beverageLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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

        private System.Windows.Forms.Label beverageLbl;
        private System.Windows.Forms.Label appetizerLbl;
        private System.Windows.Forms.Label mainCourseLbl;
        private System.Windows.Forms.Label desertLbl;
        private System.Windows.Forms.ComboBox beverageComboBox;
        private System.Windows.Forms.ComboBox appetizerComboBox;
        private System.Windows.Forms.ComboBox mainCourseComboBox;
        private System.Windows.Forms.ComboBox dessertComboBox;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button discardBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox titleOrderListBox;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.Label yourOrderLbl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

