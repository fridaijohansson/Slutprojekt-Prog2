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

namespace Server
{
    public partial class Server : Form
    {
        TcpListener lyssnare;
        List<TcpClient> klienter = new List<TcpClient>();
        TcpClient klient;

        int port = 12345;
        public Server()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            
            try
            {
                tbxLog.Text = "servern startade";
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
            btnStartServer.Enabled = false;
            SetupServer();
        }

        public async void SetupServer()
        {
            klient = null;
            try
            {
                tbxLog.Text = "startade mottagning";
                
                klient = await lyssnare.AcceptTcpClientAsync();
                klienter.Add(klient);
                tbxLog.Text = "la till användare i lista";
                StartRead(klient);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
                
            }
            
        }
        
        public async void StartRead(TcpClient k)
        {
            tbxLog.Text = "startade läsning";
            byte[] buffert = new byte[1024];

            int n = 0;

            try
            {
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
                tbxLog.Text = "fick stream";
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
            tbxLog.AppendText(Encoding.Unicode.GetString(buffert, 0, n));
            StartRead(k);
        }

       
        
    }
}

