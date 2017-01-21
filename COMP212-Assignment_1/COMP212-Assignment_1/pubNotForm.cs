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
    public partial class pubNotForm : Form
    {
        // List to hold email addresses of subscribers
        List<string> emailList = new List<string>();

        // List to hold mobile phones of subscribers
        List<string> mobileList = new List<string>();

        // Declare Delegate
        public delegate void PublishMessageDel();

        // Declare an instance variable which is a Delegate object 
        public static event PublishMessageDel publishmsg = null;

        public notManagerForm previousForm;
        public pubNotForm()
        {
            InitializeComponent();
            populateLists();
        }
        public void populateLists()
        {
            this.emailList = notManagerForm.emailList;
            this.mobileList = notManagerForm.mobileList;
        }

        public void PublishMessage()
        {
            //Invoke Delegate
            publishmsg.Invoke();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Step 1 - Show the parent form
            this.previousForm.Show();

            // Step 2 - Close this form
            this.Close();
        }

        private void publishBtn_Click(object sender, EventArgs e)
        {
            string message = contentTextBox.Text;
            string text = "";
            message = message.Trim();
            if (message == "")
            {
                MessageBox.Show("Please type a message");
            }
            else
            {
                PublishMessage();
                text += "The message \"" + message + "\" has been sent to following: \n";
                text += "Email addresses: \n";
                foreach (var email in emailList)
                {
                    text += email + "\n";
                }
                text += "Mobile numbers: \n";
                foreach (var mobile in mobileList)
                {
                    text += mobile + "\n";
                }
                MessageBox.Show(text);
            }
        }
    }
}
