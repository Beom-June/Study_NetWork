using System.Net.Sockets;
using System.Net;
using System;
using System.Threading.Tasks;
using System.Text;

namespace Study_NetWork
{
    /*
    class TapTcpUse
    {
        static async Task Main(string[] args)
        {
            await AsyncEchoServer();
        }

        async static Task AsyncEchoServer()
        {
            const int MAX_SIZE = 1024;
            TcpListener _listener = new TcpListener(IPAddress.Any, 7000);
            _listener.Start();
            Console.WriteLine("Server started...");

            while (true)
            {
                try
                {
                    TcpClient _tc = await _listener.AcceptTcpClientAsync().ConfigureAwait(false);
                    Console.WriteLine("Client connected...");

                   //Task _ = Task.Run(async () => await AsyncTcpProcess(_tc, MAX_SIZE));
                   _ = Task.Run(async () => await AsyncTcpProcess(_tc, MAX_SIZE));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }

        async static Task AsyncTcpProcess(TcpClient tc, int maxSize)
        {
            NetworkStream _stream = tc.GetStream();
            try
            {
                var _buff = new byte[maxSize];
                var _readTask = _stream.ReadAsync(_buff, 0, _buff.Length);
                var _timeoutTask = Task.Delay(10 * 1000);  // 10 seconds timeout
                var _doneTask = await Task.WhenAny(_timeoutTask, _readTask).ConfigureAwait(false);

                //  수신시 타임 아웃이면
                if (_doneTask == _timeoutTask) // 타임아웃이면
                {
                    var _bytes = Encoding.ASCII.GetBytes("Read Timeout Error");
                    await _stream.WriteAsync(_bytes, 0, _bytes.Length).ConfigureAwait(false);
                    Console.WriteLine("Read Timeout Error");
                }
                else  // 수신 성공이면
                {
                    int _nbytes = await _readTask.ConfigureAwait(false);
                    if (_nbytes > 0)
                    {
                        await _stream.WriteAsync(_buff, 0, _nbytes).ConfigureAwait(false);
                        Console.WriteLine($"Received and sent back: {Encoding.ASCII.GetString(_buff, 0, _nbytes)}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                _stream.Close();
                tc.Close();
                Console.WriteLine("Client disconnected...");
            }
        }
    }
    */
}