/*
 * COMP-212 Assignmnet - Exercise 1
 * Restaurant Bill Calculator
 * Author : Aslan Mirsakiyev
 * Date : 30 of January
 * 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class BillCalculator : Form
    {
        public BillCalculator()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // initialize variables
            decimal beveragePrice = 0M;
            decimal appetizerPrice = 0M;
            decimal mainCoursePrice = 0M;
            decimal dessertPrice = 0M;
            decimal tax = 0M;
            decimal bill =0M;

            // swtich case for beverage list box
            switch (beverageListBox.Text)
            {
                case "Soda":
                    beveragePrice = 1.95M;
                    break;

                case "Tea":
                case "Milk":
                    beveragePrice = 1.50M;
                    break;

                case "Coffee":
                    beveragePrice = 1.25M;
                    break;

                case "Mineral Water":
                    beveragePrice = 2.95M;
                    break;

                case "Juice":
                    beveragePrice = 2.50M;
                    break;

                default:
                    break;
            }


            // swtich case for appetizer list box
            switch (appetizerListBox.Text)
            {
                case "Buffalo Wings":
                    appetizerPrice = 5.95M;
                    break;

                case "Buffalo Fingers":
                case "Chips and Salsa":
                    appetizerPrice = 6.95M;
                    break;

                case "Potato Skins":
                case "Nachos":
                    appetizerPrice = 8.95M;
                    break;

                case "Mushroom Caps":
                    appetizerPrice = 10.95M;
                    break;

                case "Shrimp Cocktail":
                    appetizerPrice = 12.95M;
                    break;

                default:
                    break;
            }

            // swtich case for main course list box
            switch (mainCourseListBox.Text)
            {
                case "Seafood Alfredo":
                    mainCoursePrice = 15.95M;
                    break;

                case "Chicken Alfedo":
                case "Chicken Picatta":
                    mainCoursePrice = 13.95M;
                    break;

                case "Turkey Club":
                    mainCoursePrice = 11.95M;
                    break;

                case "Lobster Pie":
                    mainCoursePrice = 19.95M;
                    break;

                case "Prime Rib":
                    mainCoursePrice = 20.95M;
                    break;

                case "Shrimp Scampi":
                    mainCoursePrice = 18.95M;
                    break;

                case "Turkey Dinner":
                    mainCoursePrice = 13.95M;
                    break;

                case "Stuffed Chicken":
                    mainCoursePrice = 14.95M;
                    break;

                default:
                    break;
            }

            // swtich case for desert list box
            switch (dessertListBox.Text)
            {
                case "Apple Pie":
                case "Carrot Pie":
                case "Apple Crisp":
                    dessertPrice = 5.95M;
                    break;

                case "Sundae":
                    dessertPrice = 3.95M;
                    break;

                case "Mud Pie":
                    dessertPrice = 4.95M;
                    break;

                default:
                    break;
            }

            // calculating taxes(13%)
            tax = (beveragePrice + appetizerPrice + mainCoursePrice + dessertPrice) * 13 / 100;

            // calculating final bill
            bill = beveragePrice + appetizerPrice + mainCoursePrice + dessertPrice + tax;          
            billTextBox.Text = "$"+Convert.ToString(Math.Round(bill, 2));
        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            // reset all list boxes
            beverageListBox.ClearSelected();
            appetizerListBox.ClearSelected();
            mainCourseListBox.ClearSelected();
            dessertListBox.ClearSelected();
            billTextBox.Text = "$0";
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mirsakiyev/COMP212/tree/master/COMP212-Assignment_2");
        }

        private void BillCalculator_Load(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "© Copyrights - Aslan Mirsakiyev";
        }
    }
}
