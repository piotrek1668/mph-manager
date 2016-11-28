using System;
using System.Collections.Generic;

namespace MiningPoolHubManager
{
    class Coin
    {
        public String _name;
        public String name { get { return _name;  } }
        public int _port;
        public int port { get { return _port;  } }
        public String _host;
        public String host { get { return _host;  } }
        public String _algorithm;
        public String algorithm { get { return _algorithm;  } }
        public string _mode; // last 2 numbers of the port
        public string mode { get { return _mode;  } }

        public Coin(String name, int port, String host, String algorithm, string mode)
        {
            this._name = name;
            this._port = port;
            this._host = host;
            this._algorithm = algorithm;
            this._mode = mode;
        }
    }
}
