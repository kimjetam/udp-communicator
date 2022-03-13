using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDP_communicator_2022
{
    public class PksListener
    {
        private UdpClient _udpServer;
        public PksListener()
        {
        }

        public async Task ListenAsync(int port)
        {
            _udpServer = new UdpClient();
            IPEndPoint listenEndPoint = new IPEndPoint(IPAddress.Any, port);
            _udpServer.Client.Bind(listenEndPoint);


            Console.WriteLine($"UDP server: listening on port [{port}]");
            while (true)
            {
                var response = await _udpServer.ReceiveAsync();
                var responseStr = Encoding.ASCII.GetString(response.Buffer);
                Console.WriteLine($"UDP server: message received [{responseStr}]");
            }

        }
    }
}
