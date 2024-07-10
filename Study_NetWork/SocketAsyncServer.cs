using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Study_NetWork
{
    /*
    class SocketAsyncServer
    {
        static async Task RunAsyncSocketServer()
        {
            int MAX_SIZE = 1024;        //  가정

            //  1. 소켓 객체 생성 (TCP Socket)
            Socket _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //  2. 포트에 바인드
            IPEndPoint _ep = new IPEndPoint(IPAddress.Any, 7000);
            _socket.Bind(_ep);

            //  3. 포트 Listening Start
            _socket.Listen(100);

            Console.WriteLine("서버 시작됨. 클라이언트의 연결을 기다립니다...");

            while (true)
            {
                //  4. 비동기 소켓 Accept
                Socket _clientSocket = await Task.Factory.FromAsync(_socket.BeginAccept, _socket.EndAccept, null);

                // 클라이언트 연결 로그 출력
                IPEndPoint clientEndPoint = (IPEndPoint)_clientSocket.RemoteEndPoint;
                Console.WriteLine($"클라이언트 연결됨: {clientEndPoint.Address}:{clientEndPoint.Port}");

                //  5. 비동기 소켓 수신
                var _buff = new byte[MAX_SIZE];

                int _nCnt = await Task.Factory.FromAsync<int>(
                           _clientSocket.BeginReceive(_buff, 0, _buff.Length, SocketFlags.None, null, _clientSocket),
                           _clientSocket.EndReceive);

                if (_nCnt > 0)
                {
                    string _msg = Encoding.ASCII.GetString(_buff, 0, _nCnt);
                    Console.WriteLine(_msg);


                    //  6. 비동기 소켓 송신
                    await Task.Factory.FromAsync(
                            _clientSocket.BeginSend(_buff, 0, _buff.Length, SocketFlags.None, null, _clientSocket),
                            _clientSocket.EndSend);
                }

                //  7. 소켓 닫기
                Console.WriteLine($"클라이언트 연결 종료: {clientEndPoint.Address}:{clientEndPoint.Port}");
                _clientSocket.Close();
            }
        }
        static async Task Main(string[] args)
        {
            await RunAsyncSocketServer();
        }
    }
    */
}