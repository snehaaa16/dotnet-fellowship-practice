using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

namespace Streams
{
    internal class PipeCommunication
    {
        static void Main()
        {
            using (AnonymousPipeServerStream pipe =
                   new AnonymousPipeServerStream(PipeDirection.Out))
            {
                Thread writer = new Thread(() =>
                {
                    using (StreamWriter sw = new StreamWriter(pipe))
                    {
                        sw.AutoFlush = true;
                        sw.WriteLine("Hello from Writer Thread");
                        sw.WriteLine("Data sent through PipeStream");
                    }
                });

                Thread reader = new Thread(() =>
                {
                    using (AnonymousPipeClientStream client =
                           new AnonymousPipeClientStream(
                               PipeDirection.In,
                               pipe.GetClientHandleAsString()))
                    using (StreamReader sr = new StreamReader(client))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                            Console.WriteLine("Reader: " + line);
                    }
                });

                reader.Start();
                writer.Start();

                writer.Join();
                reader.Join();
            }
        }
    }
}