using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksExample;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace DisplayQueryResult
{
    public partial class TitleQueries : Form
    {
        public TitleQueries()
        {
            InitializeComponent();
        }

        private BooksExample.BooksEntities dbcontext = new BooksExample.BooksEntities();

        private void titleBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void TitleQueries_Load(object sender, EventArgs e)
        {
            dbcontext.Titles.Load();
            //querie
        }
    }
}
