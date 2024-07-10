using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace Study_NetWork
{
    /*
    class TcpServerExample
    {
        static void Main(string[] args)
        {
            // TcpListener 객체 생성. 포트 7000 에서 Listening
            TcpListener _server = new TcpListener(IPAddress.Any, 7000);
            _server.Start();

            Console.WriteLine("TCP 서버 시작. 포트 7000에서 대기 중...");

            while (true)
            {
                // 클라이언트의 연결을 기다림
                TcpClient _client = _server.AcceptTcpClient();
                Console.WriteLine("클라이언트 연결됨.");

                // 새 쓰레드에서 클라이언트 처리
                Task.Run(() => HandleClient(_client));
            }
        }

        static void HandleClient(TcpClient client)
        {
            NetworkStream _stream = client.GetStream();
            byte[] _buffer = new byte[8192];

            try
            {
                while (true)
                {
                    // 데이터 수신
                    int _bytesRead = _stream.Read(_buffer, 0, _buffer.Length);
                    if (_bytesRead == 0)
                        break;

                    string _receivedData = Encoding.UTF8.GetString(_buffer, 0, _bytesRead);
                    Console.WriteLine("수신: {0}", _receivedData);

                    // 데이터 송신 (Echo)
                    _stream.Write(_buffer, 0, _bytesRead);
                    Console.WriteLine("송신: {0}", _receivedData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("예외 발생: " + ex.Message);
            }
            finally
            {
                // 스트림 및 클라이언트 소켓 닫기
                _stream.Close();
                client.Close();
                Console.WriteLine("클라이언트 연결 종료.");
            }
        }
    }
    */
}
