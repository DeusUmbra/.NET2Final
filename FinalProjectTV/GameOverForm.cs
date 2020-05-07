using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectTV //Todd Vogel
{
    public partial class GameOverForm : Form
    {
        public GameOverForm() //This form is effectively a pop-up box to get the player's initials after they are done
        {
            InitializeComponent();
        }

        public string getInitials()
        {
            string ini = txtInitials.Text.ToUpper();
            return ini;
        }

        private void button1_Click(object sender, EventArgs e) //When they click on the submit button
        {
            if (txtInitials.Text.Length == 3) //Making sure they entered 3 letters/symbols/numbers
            {
                this.Close(); //Close as soon as the user is done
            }
            else
            {
                MessageBox.Show("You must enter 3 letters");
            }
        }
    }
}
