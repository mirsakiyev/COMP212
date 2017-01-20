using System;
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
    public partial class notManagerForm : Form
    {
        public notManagerForm()
        {
            InitializeComponent();
        }

        private void manSubBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1 - Hide the parent form
                this.Hide();

                // Step - 2 Instantiate an object for the form type
                // you are going to next
                manSubForm manageSubscriptionForm = new manSubForm();

                // Step - 3 Create a property in the next form that 
                // we will use to piont to this form
                // e.g. public AbilityGeneratorForm previousForm;

                // Step 4 - Point this form to the parent form 
                // property in the next form
                manageSubscriptionForm.previousForm = this;

                // Step 5 - Show the next form
                manageSubscriptionForm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
