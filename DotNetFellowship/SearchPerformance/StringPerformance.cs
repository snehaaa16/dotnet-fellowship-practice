using System.Text;

namespace PerformanceComparison
{
    internal class StringPerformance
    {
        public static string UsingString(int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += "A";
            }

            return result;
        }

        public static string UsingStringBuilder(int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append("A");
            }

            return result.ToString();
        }
    }
}