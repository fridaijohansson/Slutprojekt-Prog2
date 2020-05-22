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
        /// <summary>
        /// De nödvändiga variablarna för att lyssna och skicka meddelanen till klienterna samt att spara data.
        /// Endast en klient kan uppkoppla sig efter att jag la till att servern skickar tillbaka meddelanen. (funkade innan det)
        /// </summary>
        TcpListener lyssnare;
        readonly TcpClient server = new TcpClient();
        List<TcpClient> klienter = new List<TcpClient>();
        TcpClient klient;

        int kPort = 12344; //server som klient, när servern skickar meddelanden
        int sPort = 12345; //servern lyssnar på denna porten
        //egentligen meningslöst men testade för att se ifall det skulle lösa problemet med fler anslutna klienter.

        string öppnadFil = null;
        public Server()
        {
            InitializeComponent();
            server.NoDelay = true;
            
        }
        /// <summary>
        /// Startar servern innan klienter ansluter sig.
        /// Skapar en lyssnare och hänvisar vidare till att ta emot klienter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            
            try
            {
                tbxLog.AppendText("servern startade \r\n");
                lyssnare = new TcpListener(IPAddress.Any, sPort);
                lyssnare.Start();
                Mottagning();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }
            btnStartServer.Enabled = false;
            
        }
        /// <summary>
        /// Lyssnaren accepterar klienter som läggs till i en lista och en listbox.
        /// Servern ska sedan bli ansluten till klienterna men visste inte hur jag skulle göra det.
        /// Sedan anropas mottagningen igen för att låta fler klienter ansluta.
        /// Läsningen av inkommande meddelanden börjar också då jag skickar med klienten.
        /// </summary>
        private async void Mottagning()
        {
            try
            {
                tbxLog.AppendText("startade mottagning \r\n");
                
                klient = await lyssnare.AcceptTcpClientAsync();
                klienter.Add(klient);
                lbxActive.Items.Add(klient.Client.RemoteEndPoint.ToString());

                //Jag tror det är denna koden som är fel enligt catch funktionen.
                //Visste inte vad jag skulle skriva för ip adress
                await server.ConnectAsync("127.0.0.1", kPort); 
                

                Läsning(klient);
                Mottagning();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " mottagning", this.Text);
                return;
                
            }
            
        }

        /// <summary>
        /// Läsningen sker genom att lyssna på klientens variabel med GetStream.
        /// Meddelandet översätts till en string från byte och visar det i serverns logg.
        /// SkickaTillKlienter ska skicka det inkommande meddelandet till alla klienter i chatten.
        /// Läsningen anropas igen för att fortsätta lyssna på klienten.
        /// Vet fortfarande inte hur jag skickar med klienternas information, som användarnamn.
        /// </summary>
        /// <param name="k"></param>
        private async void Läsning(TcpClient k)
        {
            tbxLog.AppendText("startade läsning \r\n");
            byte[] buffert = new byte[1024];

            try
            {
                await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
                string m = Encoding.Unicode.GetString(buffert, 0, buffert.Length);
                tbxLog.AppendText(klient.Client.RemoteEndPoint + ": " + m + "\r\n");

                Läsning(k);
                SkickaTillKlienter(buffert);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message + " läsning", this.Text);
                return;
            }

            
        }
        /// <summary>
        /// Det ankommande meddelandet från klienten för med till denna funktionen som går igenom varje 
        /// klient i klientlistan för att skicka ut meddelandet till alla.
        /// Det visas sedan i serverns logg. 
        /// (vet inte varför \r\n inte fungerar på kodrad 142 för nästa data som läggs till i loggen hamnar på samma rad...)
        /// </summary>
        /// <param name="buffert"></param>
        private async void SkickaTillKlienter(byte[] buffert)
        {
            
            try
            {
                foreach (TcpClient c in klienter)
                {
                    await server.GetStream().WriteAsync(buffert, 0, buffert.Length);
                }
                string m = Encoding.Unicode.GetString(buffert, 0, buffert.Length);
                tbxLog.AppendText("Sent message to clients: " + m + " \r\n");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " skickatillklienter", this.Text);
                return;
            }
        }

        /// <summary>
        /// Servern kan spara meddelanden i filer genom spara som och spara i filen som redan sessionen är sparad i.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Lägger själv till ett namn som skickas med denna funktionen som sparar datan mha Filestream och StreamWriter som
        /// skriver ut datan i en fil.
        /// </summary>
        /// <param name="filename"></param>
        private void Spara(string filename)
        {
            FileStream utsröm = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter skrivare = new StreamWriter(utsröm);
            skrivare.Write(tbxLog.Text);
            skrivare.Dispose();
        }
    }
}

