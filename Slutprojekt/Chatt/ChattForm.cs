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
        int kPort = 12344;  //servern som klient, lyssna på denna 
        int sPort = 12345; //servern lyssnar på denna porten, skicka meddelanden hit
        readonly TcpClient klient = new TcpClient();

        //för att lyssna på serverns meddelanden
        TcpListener lyssnare;
        TcpClient server;
        IPAddress serverIp;
        public ChattForm()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }

        
        /// <summary>
        /// När fönstret skapats lägger den till prydnads egenskaper innan själva anslutningen till servern görs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChattForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                lblWelcUser.Text = "Welcome " + Connect.username.ToString();

                foreach (Users u in Connect.userlist)
                {
                    lbxActive.Items.Add(u.Username); //fungerar inte riktigt då det är samma problem som i Connect.cs

                }
                serverIp = Connect.server;
                StartaAnslutning(serverIp);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }


        }

        /// <summary>
        /// Servern måste vara igång innan klienten startas upp. Försökte göra en funktion som hanterar detta men lyckades 
        /// inte hitta en lösning.
        /// Lyssnaren startar för att lyssna på serverns meddelanden.
        /// </summary>
        /// <param name="serverIp"></param>
        private async void StartaAnslutning(IPAddress serverIp)
        {
            try
            {
                await klient.ConnectAsync(serverIp, sPort);

                

                lyssnare = new TcpListener(serverIp, kPort);
                lyssnare.Start();

                tbxChatt.AppendText("Startade lyssning \r\n");
                Mottagning();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }
            
        }
        /// <summary>
        /// Försöker acceptera servern som en klient för klienten för att kunna ta emot meddelanden.
        /// </summary>
        private async void Mottagning()
        {
            try
            {
                server = await lyssnare.AcceptTcpClientAsync();

                tbxChatt.AppendText("Startade mottagning \r\n");

                Läsning(server);
                Mottagning();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;

            }

        }

        /// <summary>
        /// läsning av servern sker som läsningen av klienterna på servern sida. 
        /// </summary>
        /// <param name="s"></param>
        private async void Läsning(TcpClient s)
        {

            tbxChatt.AppendText("startade läsning \r\n");
            byte[] buffert = new byte[1024];


            try
            {
                await s.GetStream().ReadAsync(buffert, 0, buffert.Length);
                tbxChatt.AppendText("fick stream \r\n");
                string m = Encoding.Unicode.GetString(buffert, 0, buffert.Length);
                tbxChatt.AppendText(server.Client.RemoteEndPoint + ": " + m + "\r\n");
                Läsning(s);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }


        /// <summary>
        /// Skickar meddelanden från textrutan som översätts till byte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (klient.Connected)
            {
                byte[] msg = Encoding.Unicode.GetBytes(tbxTypeBox.Text);
                StartaSändning(msg);
            }
        }
        /// <summary>
        /// Tar in byte variablen och skickar meddelandet till servern.
        /// </summary>
        /// <param name="msg"></param>
        private async void StartaSändning(byte[] msg)
        {
            try
            {
                await klient.GetStream().WriteAsync(msg, 0, msg.Length);
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

    }
}
