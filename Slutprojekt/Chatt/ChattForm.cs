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

namespace Chatt
{
    public partial class ChattForm : Form
    {
        private int port = 5678;
        private TcpClient client = new TcpClient();

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
            //foreach (Users user in Connect.userlist)
            //{
            //    lbxActive.Items.Add(user.Username);
            //}



        }
        //public async void StartStream()
        //{
        //    byte[] utdata = new byte[1024];

        //    int n = 0;

        //    try
        //    {
        //        TcpClient client = new TcpClient();
        //        await client.GetStream().WriteAsync(utdata, 0, utdata.Length);
        //        tbxChatt.Text = "fick stream";
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show(error.Message, Text);
        //        return;
        //    }
        //}

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress server = IPAddress.Parse(tbxIP.Text);
            StartaAnslutning(server);
        }
        private async void StartaAnslutning(IPAddress server)
        {
            try
            {
                await client.ConnectAsync(server, port);
                btnConnect.Enabled = true;
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
            try
            {
                await client.GetStream().WriteAsync(msg, 0, msg.Length);
                tbxChatt.AppendText(msg + "\r\n");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }
        }

        
    }
}
