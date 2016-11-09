using System;

namespace MiningPoolHubManager
{
    public class Server
    {
        public String _name;
        public String name { get { return _name; } }

        public Server(String name)
        {
            this._name = name;
        }
    }
}