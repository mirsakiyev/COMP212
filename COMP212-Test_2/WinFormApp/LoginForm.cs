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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private Test2ClassLib.Login dbcontext = new Test2ClassLib.Login();
        

        private void LoginForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "© Copyrights - Aslan Mirsakiyev - 300850326";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            pwdTextBox.Text = "";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Error occurs here
                //Test2ClassLib.Login user = dbcontext.Student
                //         .Where(user.LoginName == usernameTextBox.Text&&user.Password==pwdTextBox.Text)
                //         .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }         
        }
    }
}
