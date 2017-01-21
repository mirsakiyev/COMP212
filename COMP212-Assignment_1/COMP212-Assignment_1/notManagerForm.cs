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
        // List to hold email addresses of subscribers
        public static List<string> emailList = new List<string>();

        // List to hold mobile phones of subscribers
        public static List<string> mobileList = new List<string>();

        public notManagerForm()
        {
            InitializeComponent();
        }

        private void manSubBtn_Click(object sender, EventArgs e)
        {
            emailList.Clear();
            mobileList.Clear();
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

        private void pubNotBtn_Click(object sender, EventArgs e)
        {
            filterLists();
            try
            {
                // Step 1 - Hide the parent form
                this.Hide();

                // Step - 2 Instantiate an object for the form type
                // you are going to next
                pubNotForm publishNotification = new pubNotForm();

                // Step - 3 Create a property in the next form that 
                // we will use to piont to this form
                // e.g. public AbilityGeneratorForm previousForm;

                // Step 4 - Point this form to the parent form 
                // property in the next form
                publishNotification.previousForm = this;

                // Step 5 - Show the next form
                publishNotification.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void filterLists()
        {
            emailList = emailList.Distinct().ToList();
            mobileList = mobileList.Distinct().ToList();
        }
    }
}
