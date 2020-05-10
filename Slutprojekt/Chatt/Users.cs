using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatt
{
    public class Users
    {
        private string _username;
        private string _created;
        private int _victories;
        private string _ipAddress;

        public Users(string username, string created,string ipAddress)
        {
            this._username = username;
            this._created = created;
            this._ipAddress = ipAddress;
        }
        public Users(string username, string created, string ipAddress, int victories)
        {
            this._username = username;
            this._created = created;
            this._ipAddress = ipAddress;
            this._victories = victories;
        }

        public int Username
        {
            get { return Username; }
        }
        public int Victories
        {
            get { return Victories; }
            set { Victories = value; }
        }
    }
}
