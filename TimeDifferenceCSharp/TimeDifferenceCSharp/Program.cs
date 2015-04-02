using System;

namespace TimeDifferenceCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse("12:50");
            DateTime lastDateTime = DateTime.Parse("10:40");

            TimeSpan difference = TimeSpan.Parse((firstDate - lastDateTime).ToString());

            Console.Write(difference.Hours);
            Console.WriteLine(difference.Minutes);
        }
    }
}
