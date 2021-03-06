﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class CalculatorForm : Form
    {

        public delegate void Calculate();

        Calculate calMethod;
        public CalculatorForm()
        {
            InitializeComponent();
            calMethod = new Calculate(CalculateDel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += button0.Text;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Program.variables.Value_2 = double.Parse(resultTextBox.Text);        
            calMethod();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                Program.variables.Sing = "-";
                Program.variables.Value_1 = double.Parse(resultTextBox.Text);
                resultTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                Program.variables.Sing = "+";
                Program.variables.Value_1 = double.Parse(resultTextBox.Text);
                resultTextBox.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }      
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            try
            {
                Program.variables.Sing = "*";
                Program.variables.Value_1 = double.Parse(resultTextBox.Text);
                resultTextBox.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }        
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                Program.variables.Sing = "/";
                Program.variables.Value_1 = double.Parse(resultTextBox.Text);
                resultTextBox.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }        
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            Program.variables.Value_1 = 0;
            Program.variables.Value_2 = 0;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mirsakiyev");
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double sqrtX;
                sqrtX = double.Parse(resultTextBox.Text);
                resultTextBox.Text = Math.Sqrt(sqrtX).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += buttonDot.Text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        public void CalculateDel()
        {
            switch (Program.variables.Sing)
            {
                case "+":
                    Program.variables.Result = Program.variables.Value_1 + Program.variables.Value_2;
                    resultTextBox.Text = Program.variables.Result.ToString();
                    break;

                case "-":
                    Program.variables.Result = Program.variables.Value_1 - Program.variables.Value_2;
                    resultTextBox.Text = Program.variables.Result.ToString();
                    break;

                case "*":
                    Program.variables.Result = Program.variables.Value_1 * Program.variables.Value_2;
                    resultTextBox.Text = Program.variables.Result.ToString();
                    break;

                case "/":
                    Program.variables.Result = Program.variables.Value_1 / Program.variables.Value_2;
                    resultTextBox.Text = Program.variables.Result.ToString();
                    break;

                default:
                    break;
            }
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
