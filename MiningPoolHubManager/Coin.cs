using System;
using System.Collections.Generic;

namespace MiningPoolHubManager
{
    class Coin
    {
        private static int lastID = 0;
        public int _id;
        public int ID { get { return _id; } }
        public String _name;
        public String name { get { return _name;  } }
        public int _port;
        public int port { get { return _port;  } }
        private String _host;
        public String host { get { return _host;  } }
        public List<Mode> _modes = new List<Mode>();
        public List<Mode> modes { get { return _modes; } }
        public List<Server> _servers = new List<Server>();
        public List<Server> servers { get { return _servers;  } }

        public Coin(String name, int port, String host)
        {
            this._name = name;
            this._port = port;
            this._host = host;
            _id = ++lastID;
        }
    }
}
