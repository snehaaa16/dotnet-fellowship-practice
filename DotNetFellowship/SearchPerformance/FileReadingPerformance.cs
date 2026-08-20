using System.IO;

namespace PerformanceComparison
{
    internal class FileReadingPerformance
    {
        public static void ReadUsingStreamReader(string filePath)
        {
            using StreamReader reader = new StreamReader(filePath);

            while (reader.ReadLine() != null)
            {
            }
        }

        public static void ReadUsingFileStream(string filePath)
        {
            using FileStream stream = new FileStream(
                filePath,
                FileMode.Open,
                FileAccess.Read);

            byte[] buffer = new byte[4096];
            int bytesRead;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
            }
        }
    }
}