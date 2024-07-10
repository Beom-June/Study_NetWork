using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Study_NetWork
{
    /*
    class SocketClientExample
    {
        static void Main(string[] args)
        {
            //  1. 소켓 객체 생성 (TCP Socket)
            Socket _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //  2. 서버에 연결
            var _ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7000);
            _socket.Connect(_ep);

            string _cmd = string.Empty;         //  Read Only
            byte[] _receiverBuff = new byte[8192];

            Console.WriteLine("Connected.. Enter Q to Exit");

            //  Q를 누를 때 까지 계속 Echo 실행
            while ((_cmd = Console.ReadLine()) != "Q")
            {
                byte[] _buff = Encoding.UTF8.GetBytes(_cmd);

                //  3. 서버에 데이터 전송
                _socket.Send(_buff, SocketFlags.None);

                //  4. 서버에서 데이터 수신
                int _n = _socket.Receive(_receiverBuff);

                string _data = Encoding.UTF8.GetString(_receiverBuff, 0, _n);
                Console.WriteLine(_data);
            }

            //  5. 소켓 닫기
            _socket.Close();
        }
    }
    */
}