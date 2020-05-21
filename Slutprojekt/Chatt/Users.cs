using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Chatt
{
    public class Users
    {
        private string _username;
        private string _created;
        private IPAddress _ipAddress;
        private IPAddress _server;

        public Users(string username, string created,IPAddress ipAddress, IPAddress server)
        {
            this._username = username;
            this._created = created;
            this._ipAddress = ipAddress;
            this._server = server;
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

    }
}
