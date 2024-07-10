using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Study_NetWork
{
    /*
    class UdpClientExample
    {
        static void Main(string[] args)
        {
            // 서버의 IP 주소와 포트 번호
            string _serverIp = "127.0.0.1"; // 서버의 IP 주소를 설정
            int _serverPort = 7777;

            // 클라이언트 UdpClient 객체 생성
            UdpClient _udpClient = new UdpClient();

            // 서버의 IP 주소와 포트 번호를 설정
            IPEndPoint _serverEndPoint = new IPEndPoint(IPAddress.Parse(_serverIp), _serverPort);

            try
            {
                // 서버로 전송할 메시지
                string _message = "Hello, UDP Server!";
                byte[] _data = Encoding.UTF8.GetBytes(_message);

                // 데이터 전송
                _udpClient.Send(_data, _data.Length, _serverEndPoint);
                Console.WriteLine("[Send] {0} 바이트 송신: {1}", _data.Length, _message);

                // 서버로부터 응답 수신
                IPEndPoint _remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] _receivedData = _udpClient.Receive(ref _remoteEndPoint);
                string _receivedMessage = Encoding.UTF8.GetString(_receivedData);

                Console.WriteLine("[Receive] {0} 바이트 수신: {1}", _receivedData.Length, _receivedMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("예외 발생: " + ex.Message);
            }
            finally
            {
                // 클라이언트 종료
                _udpClient.Close();
            }
        }
    }
    */
}