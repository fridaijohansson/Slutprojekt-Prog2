using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Chatt
{
    public partial class SignIn : Form
    {
        public static List<Users> userlist = new List<Users>();
        bool exist = false;
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress server = IPAddress.Parse(tbxServer.Text);

                //
                Users defaultUser = new Users("default", "0000", IPAddress.Loopback, server);
                userlist.Add(defaultUser);
                //

                string username = tbxUsername.Text;
                string created = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString();

                
                foreach(Users u in userlist)
                {
                    if (u.Username.Equals(username)){
                        exist = true;
                    }
                    
                }
                if (exist != true)
                {
                    IPAddress userIp = IPAddress.Loopback;

                    Users user = new Users(username, created, userIp, server);

                    ChattForm form = new ChattForm();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    felmeddelande.Text = "Testa ett annat namn";
                }
                
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }
    }
}
