using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDP_receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data;
            IPEndPoint remoteAddress = new IPEndPoint(IPAddress.Any, 55000);
            Console.WriteLine("Hello World!");
            UdpClient client = new UdpClient(55000);
            while (true)
            {
                data = client.Receive(ref remoteAddress);
                string d = Encoding.ASCII.GetString(data);
                Console.WriteLine("Received UDP protocol. Data: " + d);
            }
        }
    }
}
