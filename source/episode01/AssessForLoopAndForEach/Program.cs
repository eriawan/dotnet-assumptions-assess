using BenchmarkDotNet.Running;
#if NETFRAMEWORK
using System;
#endif

namespace AssessForLoopAndForEach
{
    internal class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Benchmark!");
            BenchmarkRunner.Run<AssessForLoopForEach>();
        }
    }
}
