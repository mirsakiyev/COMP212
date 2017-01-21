using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment_1
{
    class SendViaMobile
    {
        private String cellPhone;

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            cellPhone = phone;
        }

        public void setMobile(String phone)
        {
            cellPhone = phone;
        }

        public String getMobile()
        {
            return cellPhone;
        }

        public void addToMobileList()
        {
            notManagerForm.mobileList.Add(this.cellPhone);
            MessageBox.Show(this.cellPhone);
        }
        public void removeFromMobileList()
        {
            notManagerForm.emailList.Remove(this.cellPhone);
            MessageBox.Show(this.cellPhone);
        }

        public void Subscribe(pubNotForm pubForm)
        {
            pubNotForm.publishmsg += addToMobileList;
        }

        public void Unsubscribe(pubNotForm pubForm)
        {
            pubNotForm.publishmsg += removeFromMobileList;
        }
    }
}
