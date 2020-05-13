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
        private int _victories;
        private IPAddress _ipAddress;
        private IPAddress _server;

        public Users(string username, string created,IPAddress ipAddress, IPAddress server)
        {
            this._username = username;
            this._created = created;
            this._ipAddress = ipAddress;
            this._server = server;
        }
        public Users(string username, string created, IPAddress ipAddress, int victories)
        {
            this._username = username;
            this._created = created;
            this._ipAddress = ipAddress;
            this._victories = victories;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public int Victories
        {
            get { return _victories; }
            set { _victories = value; }
        }
        public string Created
        {
            get { return _created; }
            set { _created = value; }
        }
        public IPAddress Server
        {
            get { return _server; }
            set { _server = value; }
        }

    }
}
