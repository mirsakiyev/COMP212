﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment_1
{
    public partial class manSubForm : Form
    {
        public notManagerForm previousForm;

        public manSubForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Step 1 - Show the parent form
            this.previousForm.Show();

            // Step 2 - Close this form
            this.Close();
        }
    }
}
