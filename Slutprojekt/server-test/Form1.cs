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

namespace server_test
{
    public partial class Form1 : Form
    {
        private int port = 5678;
        private TcpClient klient;
        private TcpListener lyssnare;
        public Form1()
        {
            InitializeComponent();
            StartaLyssning();
        }
        private async void StartaLyssning()
        {
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }
            StartaLäsning(klient);
        }

        private async void StartaLäsning(TcpClient klient)
        {
            try
            {
                byte[] indata = new byte[1024];
                int n = await klient.GetStream().ReadAsync(indata, 0, indata.Length);
                string msg = Encoding.Unicode.GetString(indata, 0, n);
                tbxLog.AppendText(msg + "\r\n");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }
            StartaLäsning(klient);
        }
    }
}
