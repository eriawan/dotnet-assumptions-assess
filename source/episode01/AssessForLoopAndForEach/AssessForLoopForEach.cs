using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessForLoopAndForEach
{

    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [SimpleJob(RuntimeMoniker.Net80)]
    [SimpleJob(RuntimeMoniker.Net90)]
    [MemoryDiagnoser(false)]
    public class AssessForLoopForEach
    {
        private readonly List<int> intcollections = new List<int>();

        //[Params(1_000, 10_000, 100_000)]
        [Params(100)]
        public int ListLength;

        [GlobalSetup]
        public void SetuoBenchmark()
        {
            // Initialize list
            // Ensure randomness by using current time's milliseconds.
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < ListLength; i++)
            {
                intcollections.Add(rnd.Next(1000));
            }
        }

        [Benchmark]
        public void IterateList_ForEach()
        {
            foreach (var item in intcollections)
            {

            }
        }

        [Benchmark]
        public void IterateList_ForLoop()
        {
            for (int i = 0; i < intcollections.Count; i++)
            {
                
            }
        }
    }
}
