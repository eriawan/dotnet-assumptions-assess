using BenchmarkDotNet.Running;

namespace IntroToBenchmarkDotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, BenchmarkDotnet!");
            BenchmarkRunner.Run<StringManipulation>();
        }
    }
}
