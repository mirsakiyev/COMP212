using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_2
{
    public partial class SearchForm : Form
    {
        Random random;
        int[] intVal = new int[5];
        double[] doubleVal = new double[5];        
        string searchString;

        public SearchForm()
        {
            InitializeComponent();
            random = new Random();
            genInt();
            genDouble();
        }

        // generate random int value
        private void genInt()
        {
            intTextBox.Clear();
            for (int i = 0; i < 5; i++) intVal[i] = random.Next(1,10);
            displayValues();
        }

        // generate random double value
        private void genDouble()
        {
            doubleTextBox.Clear();
            for (int i = 0; i < 5; i++) doubleVal[i] = Math.Round(random.NextDouble()*10,1);
            displayValues();
        }

        // display int and double values into textboxes
        private void displayValues()
        {
            intTextBox.Text = string.Join(", ", intVal); 
            doubleTextBox.Text = string.Join(", ", doubleVal);
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            genInt();
            genDouble();
        }

        // method to search value with IComparable
        private int search<T>(T searchVal, T[] array) where T : IComparable<T>
        {
            int intIndex = -1;
            int a = 0;

            foreach (var i in array)
            {
                if (searchVal.CompareTo(i) > 0)
                {
                    intIndex = a;
                    break;
                }
                a++;
            }
            return intIndex;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                searchString = searchTextBox.Text;
                int index = search<int>(int.Parse(searchString), intVal);
                if (index == -1)
                {
                    MessageBox.Show("Couldnt find value "+ searchString + " in int array");
                }
                else
                {
                    MessageBox.Show(searchString + " int array, index: " + index);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }           
        }
    }
}
