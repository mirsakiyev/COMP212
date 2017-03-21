using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class RegistrationForm : Form
    {
        public LoginForm previousForm;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "© Copyrights - Aslan Mirsakiyev - 300850326";

            using (Test2ClassLib.SMSEntities c = new Test2ClassLib.SMSEntities())
            {
                coursesComboBox.ItemSource = c.Courses.ToList();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
    }
}
