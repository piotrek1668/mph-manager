using System;

namespace MiningPoolHubManager
{
    class Algo
    {
        public String _name;
        public String name { get { return _name; } }
        public int _port;
        public int port { get { return _port; } }
        public String _host;
        public String host { get { return _host; } }
        public String _algorithm;
        public String algorithm { get { return _algorithm; } }

        public Algo(String name, int port, string host, string algorithm)
        {
            this._name = name;
            this._port = port;
            this._host = host;
            this._algorithm = algorithm;
        }
    }
}
