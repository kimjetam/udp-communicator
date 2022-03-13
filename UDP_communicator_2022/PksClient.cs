using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace UDP_communicator_2022
{
    public class PksClient
    {
        private IPEndPoint _ipEndPoint;
        private UdpClient _udpClient;
        public PksClient(string ipAddress, int port)
        {
            _ipEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
        }

        public void Connect()
        {
            _udpClient = new UdpClient();
            _udpClient.Connect(_ipEndPoint);

            var message = "Is anybody there?";
            var sendBytes = Encoding.ASCII.GetBytes(message);

            _udpClient.Send(sendBytes, sendBytes.Length);

            Console.WriteLine($"UDP Client: message sent [{message}]");

        }
    }
}
