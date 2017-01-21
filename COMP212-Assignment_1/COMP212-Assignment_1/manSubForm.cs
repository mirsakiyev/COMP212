using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment_1
{

    public partial class manSubForm : Form
    {

        static string email = "", mobile = "";
        static bool emailChecked = false, mobileChecked = false;
        static bool isValidEmail = false, isValidMobile = false;

        public pubNotForm pubForm = new pubNotForm();

        SendViaEmail send2Email;
        SendViaMobile send2Mobile;

        public notManagerForm previousForm;

        public manSubForm()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailCheckB_CheckedChanged(object sender, EventArgs e)
        {
            //Enable email textbox only if the email checkbox is checked
            emailTextBox.Enabled = emailChecked = (emailCheckB.Checked) ? true : false;
        }

        private void unsubscribeBtn_Click(object sender, EventArgs e)
        {
            sendEmailMobile("Unsubscription");
            if (emailChecked && mobileChecked)
            {
                if (isValidEmail && isValidMobile)
                {
                    MessageBox.Show("Unsubscription successful!!!");
                    send2Email = new SendViaEmail(email);
                    send2Email.Unsubscribe(pubForm);
                    send2Mobile = new SendViaMobile(mobile);
                    send2Mobile.Unsubscribe(pubForm);
                }
                else
                {
                    MessageBox.Show("Please check your mobile/ email address");
                }

            }
            else if (emailChecked && !mobileChecked)
            {
                if (isValidEmail)
                {
                    send2Email = new SendViaEmail(email);
                    send2Email.Unsubscribe(pubForm);
                }
                else
                {
                    MessageBox.Show("Please check your email address");
                }
            }
            else if (mobileChecked && !emailChecked)
            {
                if (isValidMobile)
                {
                    send2Mobile = new SendViaMobile(mobile);
                    send2Mobile.Unsubscribe(pubForm);
                }
                else
                {
                    MessageBox.Show("Please check your mobile number");
                }
            }
        }

        private void mobileCheckB_CheckedChanged(object sender, EventArgs e)
        {
            //Enable mobile textbox only if the mobile checkbox is checked
            mobileTextBox.Enabled = mobileChecked = (mobileCheckB.Checked) ? true : false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Step 1 - Show the parent form
            this.previousForm.Show();

            // Step 2 - Close this form
            this.Close();
        }


        private void subscribeBtn_Click(object sender, EventArgs e)
        {
            string message = "";
            sendEmailMobile("Subscription");
            if (emailChecked && mobileChecked)
            {
                if (isValidEmail && isValidMobile)
                {
                    send2Email = new SendViaEmail(email);
                    send2Email.Subscribe(pubForm);
                    send2Mobile = new SendViaMobile(mobile);
                    send2Mobile.Subscribe(pubForm);
                    message = "Subscription successful";
                }
                else
                {
                    message = "Please check your mobile / email address";
                }

            }
            else if (emailChecked && !mobileChecked)
            {
                if (isValidEmail)
                {
                    message = "Subscription successful";
                    send2Email = new SendViaEmail(email);
                    send2Email.Subscribe(pubForm);
                }
                else
                {
                    message = "Please check your email address";
                }
            }
            else if (mobileChecked && !emailChecked)
            {
                if (isValidMobile)
                {
                    message = "Subscription successful!!!";
                    send2Mobile = new SendViaMobile(mobile);
                    send2Mobile.Subscribe(pubForm);
                }
                else
                {
                    message = "Please check your mobile number";
                }
            }
            MessageBox.Show(message);
        }
        private void sendEmailMobile(string subscribe)
        {
            if (emailChecked)
            {
                email = emailTextBox.Text;
                isValidEmail = validateEmail(email);
            }
            if (mobileChecked)
            {
                mobile = mobileTextBox.Text;
                isValidMobile = validateMobile(mobile);
            }
            if (!emailChecked && !mobileChecked)
            {
                MessageBox.Show("Enter atleast an email or mobile number for " + subscribe);
            }
        }

        private bool validateEmail(string email)
        {
            string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool validateMobile(string mobile)
        {
            string pattern = @"(\d{3}[-]){2}\d{4}";
            if (Regex.IsMatch(mobile, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
