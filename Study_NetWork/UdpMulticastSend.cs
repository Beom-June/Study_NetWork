using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study_NetWork
{
    /*
    class UdpMulticastSend
    {
        // 멀티캐스트 전송(Send)

        static void Main(string[] args)
        {
            // (1) UdpClient 객체 성성
            UdpClient _udpClient = new UdpClient();

            // (2) Multicast 종단점 설정            
            IPEndPoint _multicastEP = new IPEndPoint(IPAddress.Parse("229.1.1.229"), 5500);

            for (int i = 1; i <= 60; i++)
            {
                byte[] _dgram = Encoding.ASCII.GetBytes("Msg#" + i);

                // (3) Multicast 그룹에 데이타그램 전송      
                _udpClient.Send(_dgram, _dgram.Length, _multicastEP);

                Console.WriteLine("Msg#" + i);
                Thread.Sleep(1000);
            }
        }
    }
    */
}