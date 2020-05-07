using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectTV
{
    public partial class HighscoreForm : Form
    {
        bool iClick = false; //Variables for if the option has been clicked before.
        bool sClick = false;
        bool fClick = false;
        bool dClick = false;
        public HighscoreForm()
        {
            InitializeComponent();
        }

        private void HighscoreForm_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'gameInfoDataSet.Scoreboard' table.
            this.scoreboardTableAdapter.Fill(this.gameInfoDataSet.Scoreboard);

        }

        private void btnInitials_Click(object sender, EventArgs e)
        {
            if (!iClick) //If it has not been clicked before
            {
                scoreboardBindingSource.Sort = "Initials DESC";
                iClick = true;
            }
            else //If it has been clicked before
            {
                scoreboardBindingSource.Sort = "Initials ASC";
                iClick = false;
            }
        } //I set up the if...else so that the user can click an option again to switch between
        //Ascending and Descending sort order.

        private void btnScore_Click(object sender, EventArgs e)
        {
            if (!sClick)
            {
                scoreboardBindingSource.Sort = "Score DESC";
                sClick = true;
            }
            else
            {
                scoreboardBindingSource.Sort = "Score ASC";
                sClick = false;
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            if (!fClick)
            {
                scoreboardBindingSource.Sort = "Finished DESC";
                fClick = true;
            }
            else
            {
                scoreboardBindingSource.Sort = "Finished ASC";
                fClick = false;
            }
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            if (!dClick)
            {
                scoreboardBindingSource.Sort = "Date DESC";
                dClick = true;
            }
            else
            {
                scoreboardBindingSource.Sort = "Date ASC";
                dClick = false;
            }
        }
    }
}
