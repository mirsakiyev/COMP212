﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayBooks
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private Books_Example.BooksEntities dbcontext = new Books_Example.BooksEntities();

        private void BooksForm_Load(object sender, EventArgs e)
        {
            dbcontext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();

            authorBindingSource.DataSource = dbcontext.Authors.Local;

            dbcontext.Titles
                .OrderBy(title => title.Title1)
                .ThenBy(title => title.EditionNumber)
                .Load();

            titleBindingSource.DataSource = dbcontext.Titles.Local;
        }
    }
}
