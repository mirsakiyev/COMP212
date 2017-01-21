using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment_1
{
    class SendViaEmail
    {
        private String email;
        pubNotForm publishForm = new pubNotForm();

        public SendViaEmail() { }

        public SendViaEmail(String email)
        {
            this.email = email;
        }

        public void setEmailAddr(String email)
        {
            this.email = email;
        }

        public String getEmailAddr()
        {
            return email;
        }

        public void addToEmailList()
        {
            notManagerForm.emailList.Add(this.email);
            MessageBox.Show(this.email);
        }
        public void removeFromEmailList()
        {
            notManagerForm.emailList.Remove(this.email);
            MessageBox.Show(this.email);
        }

        public void Subscribe(pubNotForm pubForm)
        {
            pubNotForm.publishmsg += addToEmailList;
        }

        public void Unsubscribe(pubNotForm pubForm)
        {
            pubNotForm.publishmsg += removeFromEmailList;
        }
    }
}
