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
using System.IO;

namespace Server
{
    public partial class Server : Form
    {
        TcpListener lyssnare;
        List<TcpClient> klienter = new List<TcpClient>();
        TcpClient klient;
        int port = 12345;

        string öppnadFil = null;
        public Server()
        {
            InitializeComponent();
            
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            
            try
            {
                tbxLog.AppendText("servern startade \r\n");
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

        private async void SetupServer()
        {
            try
            {
                tbxLog.AppendText("startade mottagning \r\n");
                
                klient = await lyssnare.AcceptTcpClientAsync();
                klienter.Add(klient);
                


                tbxLog.AppendText("la till användare i lista \r\n");
                lbxActive.Items.Add(klient.Client.ToString());
                StartRead(klient);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
                
            }
            SetupServer();
        }
        
        private async void StartRead(TcpClient k)
        {
            tbxLog.AppendText("startade läsning \r\n");
            byte[] buffert = new byte[1024];

            int n = 0;

            try
            {
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
                tbxLog.AppendText("fick stream \r\n");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }

            string m = Encoding.Unicode.GetString(buffert, 0, n);
            tbxLog.AppendText(klient + ": "+ m + "\r\n");
            StartRead(k);
        }







        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                öppnadFil = saveFileDialog1.FileName;
                Spara(öppnadFil);
            }
        }

        private void sparaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (öppnadFil == null)
            {
                if (DialogResult.OK == saveFileDialog1.ShowDialog())
                {
                    öppnadFil = saveFileDialog1.FileName;
                    Spara(öppnadFil);
                }
            }
            else
            {
                Spara(öppnadFil);
            }
        }

        private void Spara(string filename)
        {
            FileStream utsröm = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter skrivare = new StreamWriter(utsröm);
            skrivare.Write(tbxLog.Text);
            skrivare.Dispose();
        }
    }
}

