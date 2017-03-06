using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayauthorsTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Entity framework DBContent
        private BooksExample.BooksEntities dbcontext = new BooksExample.BooksEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            dbcontext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();

            authorBindingSource.DataSource = dbcontext.Authors.Local;
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            authorBindingSource.EndEdit();

            try
            {
                dbcontext.SaveChanges();
            }
            catch (DbEntityValidationException)
            {
                throw;
            }
        }
    }
}
