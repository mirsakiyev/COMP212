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
    public partial class userControlForm : Form
    {
        public userControlForm()
        {           
            InitializeComponent();
            loginBtn.Select();
        }

        private void userControlForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            pwdTextBox.Clear();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && pwdTextBox.Text!="")
            {
                UserInfo user = new UserInfo();
                user.Username = usernameTextBox.Text;
                user.Password = pwdTextBox.Text;
                MessageBox.Show("Logged as " + user.Username + "\nWith password: " + user.Password);
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }     
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            pwdTextBox.Clear();
            usernameTextBox.Focus();
        }
    }
}
