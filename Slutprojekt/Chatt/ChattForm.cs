using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Remoting.Channels;

namespace Chatt
{
    public partial class ChattForm : Form
    {
        private int port = 12345;
        private TcpClient client = new TcpClient();
        Users user;

        public ChattForm()
        {
            InitializeComponent();
            client.NoDelay = true;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChattForm_Load(object sender, EventArgs e)
        {
            foreach (Users u in Connect.userlist)
            {
                lbxActive.Items.Add(u.Username);
                

            }
            IPAddress server = Connect.server;
            StartaAnslutning(server);




        }

        
        private async void StartaAnslutning(IPAddress server)
        {
            try
            {
                await client.ConnectAsync(server, port);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                byte[] msg = Encoding.Unicode.GetBytes(tbxTypeBox.Text);
                StartaSändning(msg);
            }
        }
        private async void StartaSändning(byte[] msg)
        {
            byte[] utdata = new byte[1024];

            int n = 0;
            try
            {
                await client.GetStream().WriteAsync(msg, 0, msg.Length);
                string m = Encoding.Unicode.GetString(msg, 0, msg.Length);
                tbxChatt.AppendText(m + "\r\n");
                tbxTypeBox.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }
        }

        private void lblWelcUser_Click(object sender, EventArgs e)
        {
            lblWelcUser.Text = "Welcome "+ user.Username;
        }
    }
}
