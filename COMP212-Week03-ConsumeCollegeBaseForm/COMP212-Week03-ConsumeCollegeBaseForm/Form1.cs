using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP212_Week03_Visual_Inheritance_ex;

namespace COMP212_Week03_ConsumeCollegeBaseForm
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(programCodeTextBox.Text);
        }
    }
}
