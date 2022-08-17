using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.IO;

namespace AxeheimMUD.Server
{
    internal class TcpServerListener
    {
        private static int _port = 9090;
        private static IPAddress _localAddress = IPAddress.Parse("127.0.0.1");

        private TcpListener _server = new TcpListener(_localAddress, _port);
        
    }
}
