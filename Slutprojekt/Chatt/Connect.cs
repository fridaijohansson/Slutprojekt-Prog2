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


namespace Chatt
{
    public partial class Connect : Form
    {
        public static List<Users> userlist = new List<Users>();
        TcpClient client = new TcpClient();
        int port = 12345;
        public Connect()
        {
            InitializeComponent();
            client.NoDelay = true;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!client.Connected)
                {
                    TryConnect();
                    ChattForm form = new ChattForm();
                    form.ShowDialog();
                    this.Close();
                }
                
                
            }
            catch
            {
                felmeddelande.Text = "kunde inte ansluta";
            }
            
           


        }

        public async void TryConnect()
        {
            try
            {
                IPAddress server = IPAddress.Parse(tbxServer.Text);
                
                await client.ConnectAsync(server, port);
                string username = tbxUsername.Text;
                string created = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString();
                //username metod check i lista ifall den redan existerar
                foreach(Users user in userlist)
                {
                    if(username.Equals(user.Username))
                    {
                        felmeddelande.Text = "Try a different username";
                    }
                    else
                    {
                        Users u = new Users(username, created, server.ToString());
                        userlist.Add(u);

                    }
                }
            }
            catch(Exception error)
            {
                felmeddelande.Text = error + "Kunde inte ansluta";
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
