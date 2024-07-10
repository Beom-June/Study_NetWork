using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study_NetWork
{
    /*
    class UdpMulticastReceive
    {
        static void Main(string[] args)
        {
            // (1) UdpClient 객체 성성
            UdpClient _udp = new UdpClient();

            // (2) UDP 로컬 IP/포트에 바인딩            
            // udp.Client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, true);
            IPEndPoint _localEP = new IPEndPoint(IPAddress.Any, 5500);
            _udp.Client.Bind(_localEP);

            // (3) Multicast 그룹에 Join
            IPAddress _multicastIP = IPAddress.Parse("229.1.1.229");
            _udp.JoinMulticastGroup(_multicastIP);

            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            while (!Console.KeyAvailable)
            {
                // (4) Multicast 수신
                byte[] _buff = _udp.Receive(ref remoteEP);

                string _data = Encoding.ASCII.GetString(_buff, 0, _buff.Length);
                Console.WriteLine(_data);
            }
        }
    }
    */
}
