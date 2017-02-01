using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2
{
    public partial class LoggedInForm : Form
    {
        public UserControl previousForm;

        public LoggedInForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            
            // Step 1 - Show the parent form
            this.previousForm.Show();

            // Step 2 - Close this form
            this.Close();
         
            if(Program.user.RememberMe == false)
            // Reset UserName and Password textboxes if RememberMe property is FALSE
            {
                previousForm.usernameTextBox.Clear();
                previousForm.pwdTextBox.Clear();

                previousForm.usernameTextBox.Focus();
            }
            
            
        }

        private void LoggedInForm_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLbl.Text = "User: " + Program.user.Username;
            this.usernameLbl.Text = "You are logged in as "+Program.user.Username;
            this.pwdLbl.Text = "With the password: " + Program.user.Password;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mirsakiyev/");
        }
    }
}
