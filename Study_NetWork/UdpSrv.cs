using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Study_NetWork
{
    /*
    class UdpSrv
    {
        static void Main(string[] args)
        {
            // (1) UdpClient 객체 성성. 포트 7777 에서 Listening
            UdpClient _udpClient = new UdpClient(7777);

            // 클라이언트 IP를 담을 변수
            IPEndPoint _remoteEP = new IPEndPoint(IPAddress.Any, 0);

            Console.WriteLine("UDP 서버 시작. 포트 7777에서 대기 중...");

            while (true)
            {
                try
                {
                    // 데이터 수신
                    byte[] _dgram = _udpClient.Receive(ref _remoteEP);
                    string _receivedMessage = Encoding.UTF8.GetString(_dgram);
                    Console.WriteLine("[Receive] {0} 로부터 {1} 바이트 수신: {2}", _remoteEP.ToString(), _dgram.Length, _receivedMessage);

                    // 데이터 송신
                    _udpClient.Send(_dgram, _dgram.Length, _remoteEP);
                    Console.WriteLine("[Send] {0} 로 {1} 바이트 송신: {2}", _remoteEP.ToString(), _dgram.Length, _receivedMessage);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("예외 발생: " + ex.Message);
                }
            }
        }
    }
    */
}