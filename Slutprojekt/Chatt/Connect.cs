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
        public static string username;
        bool exist;
        public Connect()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Skapar en användare med användarnamn, servernden vill ansluta till och när användaren var skapad.
        /// En if-sats sker för att se om fler än en har användarnamnen, men fungerar inte helt då alla klienter inte har tillgång till
        /// andra klienter. Möjligtvis att jag skulle ha lagt Users-klassen i servern ist men jag vet inte hur man kommer åt datan praktiskt.
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                server = IPAddress.Parse(tbxServer.Text);
                username = tbxUsername.Text;
                string created = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString();

                //Dessa kodrader är till för att se om if-satsen fungerade för användarnamnen.
                //Users defaultUser = new Users("default", "0000", IPAddress.Loopback, server);
                //userlist.Add(defaultUser); //så länge jag skapar en användare här kan programmet ej köras mer än en gång.



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


       
    }
}
