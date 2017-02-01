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
    public partial class UserControl : Form
    {
        public UserControl()
        {           
            InitializeComponent();
            loginBtn.Select();
        }

        private void userControlForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
            this.toolStripStatusLbl.Text = "© Copyrights - Aslan Mirsakiyev";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (usernameTextBox.Text != "" && pwdTextBox.Text!="")
            {
                Program.user.Username = usernameTextBox.Text;
                Program.user.Password = pwdTextBox.Text;

                // if rememberMeCheckBox is checked then 
                // save it as TRUE in a RememberMe property
                // else save it as FALSE
                if (rememberMeCheckBox.Checked==true)
                {
                    Program.user.RememberMe = true;
                }
                else
                {
                    Program.user.RememberMe = false;
                }

                try
                {
                    // Step 1 - Hide the parent form
                    this.Hide();

                    // Step - 2 Instantiate an object for the form type
                    // you are going to next
                    LoggedInForm orderForm = new LoggedInForm();

                    // Step - 3 Create a property in the next form that 
                    // we will use to piont to this form
                    // e.g. public AbilityGeneratorForm previousForm;

                    // Step 4 - Point this form to the parent form 
                    // property in the next form
                    orderForm.previousForm = this;

                    // Step 5 - Show the next form
                    orderForm.Show();
                }
                catch (Exception)
                {

                    throw;
                }

                // Save user credentials if RememberMe property is TRUE
                if (Program.user.RememberMe == true)
                {
                    usernameTextBox.Text = Program.user.Username;
                    pwdTextBox.Text = Program.user.Password;
                }
            }
            else
            {
                if (usernameTextBox.Text=="")
                {
                    usernameTextBox.Focus();
                }
                if (pwdTextBox.Text=="")
                {
                    pwdTextBox.Focus();
                }

                MessageBox.Show("Please enter username and password");
                usernameTextBox.Focus();
            }           
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear all textboxes and focus user input on usernameTextBox
            usernameTextBox.Clear();
            pwdTextBox.Clear();
            rememberMeCheckBox.Checked = false;
            usernameTextBox.Focus();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mirsakiyev/");
        }
    }
}
