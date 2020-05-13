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
        public static IPAddress server;
        bool exist;
        public Connect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                server = IPAddress.Parse(tbxServer.Text);
                string username = tbxUsername.Text;
                string created = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString();

                Users defaultUser = new Users("default", "0000", IPAddress.Loopback, server);
                userlist.Add(defaultUser); //så länge jag skapar en användare här kan programmet ej köras mer än en gång.

                foreach (Users user in userlist)
                {

                    if (username.Equals(user.Username))
                    {
                        felmeddelande.Text = "Try a different username";
                        exist = true;
                    }
                    else if (username.Equals(""))
                    {
                        felmeddelande.Text = "You need a username";
                        exist = true;
                    }
                }

                if (exist != true)
                {
                    MessageBox.Show("Added: " + username + " " + created + " " + IPAddress.Loopback,
                        "text");

                    Users u = new Users(username, created, IPAddress.Loopback, server);
                    userlist.Add(u);

                    ChattForm form = new ChattForm();
                    form.ShowDialog();
                    this.Hide();
                }

            }
            catch (Exception error)
            {
                felmeddelande.Text = "kunde inte ansluta";
                MessageBox.Show(error.Message, "error", MessageBoxButtons.OK);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
