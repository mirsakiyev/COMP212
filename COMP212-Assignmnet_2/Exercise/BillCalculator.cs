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
            double beveragePrice = 0;
            double appetizerPrice = 0;
            double mainCoursePrice = 0;
            double desertPrice = 0;
            double tax = 0;
            double bill=0;

            switch (beverageListBox.Text)
            {
                case "Soda":
                    beveragePrice = 1.95;
                    break;

                case "Tea":
                    beveragePrice = 1.50;
                    break;

                case "Coffee":
                    beveragePrice = 1.25;
                    break;

                case "Mineral Water":
                    beveragePrice = 2.95;
                    break;

                case "Juice":
                    beveragePrice = 2.50;
                    break;

                case "Milk":
                    beveragePrice = 1.50;
                    break;

                default:
                    break;
            }

            tax = (beveragePrice + appetizerPrice + mainCoursePrice + desertPrice) * 13 / 100;
            bill = beveragePrice + appetizerPrice + mainCoursePrice + desertPrice+tax;
            billTextBox.Text = Convert.ToString(bill);

        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            //beverageListBox.Items.Clear();
        }
    }
}
