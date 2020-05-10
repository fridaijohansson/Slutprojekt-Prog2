using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatt
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }








        private void btnRestart_Click(object sender, EventArgs e)
        {

        }






        private void btnLeave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to leave the game?", "Exit Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
