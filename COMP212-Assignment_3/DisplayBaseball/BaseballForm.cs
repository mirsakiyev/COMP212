using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DisplayBaseball
{
    public partial class BaseballForm : Form
    {
        public BaseballForm()
        {
            InitializeComponent();
        }

        private Baseball_Example.BaseballEntities dbcontext = new Baseball_Example.BaseballEntities();
        private string playerName;
        private void playerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void BaseballForm_Load(object sender, EventArgs e)
        {
            // Order by last name(then by first name)
            dbcontext.Players
                .OrderBy(player => player.LastName)
                .ThenBy(player => player.FirstName)
                .Load();

            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            playerName = playerTextBox.Text;
            playerName = playerName.ToUpper();
            var query = dbcontext.Players.Local.Where(Player => Player.LastName.ToUpper() == playerName);

            playerBindingSource.DataSource = query;
            playerBindingSource.MoveFirst();
        }

        private void displayAllBtn_Click(object sender, EventArgs e)
        {
            dbcontext.Players.Load();
            playerBindingSource.DataSource = dbcontext.Players.Local;
            playerTextBox.Text = "";
        }
    }
}
