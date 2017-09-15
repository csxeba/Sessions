using System.Net;
using System.Net.Sockets;

namespace Examples
{
    public static class SocketExample
    {
        public static void Connect(string host, int port)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port));

            socket.Send(new byte[] { 0x00, 0x00, 0x00, 0x00 });
            socket.Receive(new byte[4]);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
