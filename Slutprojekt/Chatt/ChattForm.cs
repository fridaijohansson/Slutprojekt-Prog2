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
    public partial class ChattForm : Form
    {
        
        public ChattForm()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChattForm_Load(object sender, EventArgs e)
        {
            foreach (Users user in Connect.userlist)
            {
                lbxActive.Items.Add(user.Username);
            }



        }
    }
}
