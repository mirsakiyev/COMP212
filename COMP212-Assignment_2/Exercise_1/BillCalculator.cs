using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1
{
    public partial class BillCalculator : Form
    {
        public BillCalculator()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // initialize variables
            decimal beveragePrice = 0M;
            decimal appetizerPrice = 0M;
            decimal mainCoursePrice = 0M;
            decimal dessertPrice = 0M;
            
            // swtich case for beverage combo box
            switch (beverageComboBox.Text)
            {
                case "Soda":
                    beveragePrice = 1.95M;
                    orderListBox.Items.Add("$"+beveragePrice);
                    titleOrderListBox.Items.Add(beverageComboBox.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                case "Tea":
                case "Milk":
                    beveragePrice = 1.50M;
                    orderListBox.Items.Add("$" + beveragePrice);
                    titleOrderListBox.Items.Add(beverageComboBox.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                case "Coffee":
                    beveragePrice = 1.25M;
                    orderListBox.Items.Add("$" + beveragePrice);
                    titleOrderListBox.Items.Add(beverageComboBox.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                case "Mineral Water":
                    beveragePrice = 2.95M;
                    orderListBox.Items.Add("$" + beveragePrice);
                    titleOrderListBox.Items.Add(beverageComboBox.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                case "Juice":
                    beveragePrice = 2.50M;
                    orderListBox.Items.Add("$" + beveragePrice);
                    titleOrderListBox.Items.Add(beverageComboBox.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                default:
                    break;
            }


            // swtich case for appetizer combo box
            switch (appetizerComboBox.Text)
            {
                case "Buffalo Wings":
                    appetizerPrice = 5.95M;
                    orderListBox.Items.Add("$" + appetizerPrice);
                    titleOrderListBox.Items.Add(appetizerComboBox.Text);
                    Program.variables.Bill += appetizerPrice;
                    break;

                case "Buffalo Fingers":
                case "Chips and Salsa":
                    appetizerPrice = 6.95M;
                    orderListBox.Items.Add("$" + appetizerPrice);
                    titleOrderListBox.Items.Add(appetizerComboBox.Text);
                    Program.variables.Bill += appetizerPrice;
                    break;

                case "Potato Skins":
                case "Nachos":
                    appetizerPrice = 8.95M;
                    orderListBox.Items.Add("$" + appetizerPrice);
                    titleOrderListBox.Items.Add(appetizerComboBox.Text);
                    Program.variables.Bill += appetizerPrice;
                    break;

                case "Mushroom Caps":
                    appetizerPrice = 10.95M;
                    orderListBox.Items.Add("$" + appetizerPrice);
                    titleOrderListBox.Items.Add(appetizerComboBox.Text);
                    Program.variables.Bill += appetizerPrice;
                    break;

                case "Shrimp Cocktail":
                    appetizerPrice = 12.95M;
                    orderListBox.Items.Add("$" + appetizerPrice);
                    titleOrderListBox.Items.Add(appetizerComboBox.Text);
                    Program.variables.Bill += appetizerPrice;
                    break;

                default:
                    break;
            }

            // swtich case for main course combo box
            switch (mainCourseComboBox.Text)
            {
                case "Seafood Alfredo":
                    mainCoursePrice = 15.95M;
                    orderListBox.Items.Add("$" + mainCoursePrice);
                    titleOrderListBox.Items.Add(mainCourseComboBox.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Chicken Alfedo":
                case "Chicken Picatta":
                    mainCoursePrice = 13.95M;
                    orderListBox.Items.Add("$" + mainCoursePrice);
                    titleOrderListBox.Items.Add(mainCourseComboBox.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Turkey Club":
                    mainCoursePrice = 11.95M;
                    orderListBox.Items.Add("$" + mainCoursePrice);
                    titleOrderListBox.Items.Add(mainCourseComboBox.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Lobster Pie":
                    mainCoursePrice = 19.95M;
                    orderListBox.Items.Add("$" + mainCoursePrice);
                    titleOrderListBox.Items.Add(mainCourseComboBox.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Prime Rib":
                    mainCoursePrice = 20.95M;
                    orderListBox.Items.Add("$" + mainCoursePrice);
                    titleOrderListBox.Items.Add(mainCourseComboBox.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Shrimp Scampi":
                    mainCoursePrice = 18.95M;
                    orderListBox.Items.Add("$" + mainCoursePrice);
                    titleOrderListBox.Items.Add(mainCourseComboBox.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Turkey Dinner":
                    mainCoursePrice = 13.95M;
                    orderListBox.Items.Add("$" + mainCoursePrice);
                    titleOrderListBox.Items.Add(mainCourseComboBox.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Stuffed Chicken":
                    mainCoursePrice = 14.95M;
                    orderListBox.Items.Add("$" + mainCoursePrice);
                    titleOrderListBox.Items.Add(mainCourseComboBox.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                default:
                    break;
            }

            // swtich case for desert combo box
            switch (dessertComboBox.Text)
            {
                case "Apple Pie":
                case "Carrot Pie":
                case "Apple Crisp":
                    dessertPrice = 5.95M;
                    orderListBox.Items.Add("$" + dessertPrice);
                    titleOrderListBox.Items.Add(dessertComboBox.Text);
                    Program.variables.Bill += dessertPrice;
                    break;

                case "Sundae":
                    dessertPrice = 3.95M;
                    orderListBox.Items.Add("$" + dessertPrice);
                    titleOrderListBox.Items.Add(dessertComboBox.Text);
                    Program.variables.Bill += dessertPrice;
                    break;

                case "Mud Pie":
                    dessertPrice = 4.95M;
                    orderListBox.Items.Add("$" + dessertPrice);
                    titleOrderListBox.Items.Add(dessertComboBox.Text);
                    Program.variables.Bill += dessertPrice;
                    break;

                default:
                    break;
            }

            

            //reset all combo boxes
            beverageComboBox.ResetText();
            appetizerComboBox.ResetText();
            mainCourseComboBox.ResetText();
            dessertComboBox.ResetText();


        }

      
        private void discardBtn_Click(object sender, EventArgs e)
        {
            calcBtn.Enabled = true;
            addBtn.Enabled = true;

            // discard all combo boxes, list boxes and reset bill
            beverageComboBox.ResetText();
            appetizerComboBox.ResetText();
            mainCourseComboBox.ResetText();
            dessertComboBox.ResetText();

            orderListBox.Items.Clear();
            titleOrderListBox.Items.Clear();

            Program.variables.Bill = 0M;
            billTextBox.Text ="$0";
        }

        private void BillCalculator_Load(object sender, EventArgs e)
        {
            calcBtn.Enabled = true;
            addBtn.Enabled = true;
            billTextBox.Text = "$0";
            this.toolStripStatusLabel.Text = "© Copyrights - Aslan Mirsakiyev";
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mirsakiyev");
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            Program.variables.Bill += Program.variables.Bill * 13 / 100;
            billTextBox.Text = "$" + Math.Round(Program.variables.Bill, 2).ToString();

            calcBtn.Enabled = false;
            addBtn.Enabled = false;
        }
    }
}
