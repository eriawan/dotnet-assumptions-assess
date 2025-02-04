using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToBenchmarkDotnet
{
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net80)]
    [SimpleJob(RuntimeMoniker.Net90)]
    [MemoryDiagnoser(displayGenColumns: true)]
    public class StringManipulation
    {
        private String str1 = "str01";

        [Benchmark]
        public void StringConcatUsingPlus()
        {
            string str2 = "";
            for (int i = 0; i < 1000; i++)
            {
                str2 = str1 + str1;
            }
        }

        [Benchmark]
        public void StringConcatWithStringBuilder()
        {
            string str2 = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(str1);
            }
            str2 = sb.ToString();
        }

        [Benchmark]
        public void StringConcatUsingSpan()
        {
            string str2 = "";
            for (int i = 0; i < 1000; i++)
            {
                str2 = String.Concat(str2.AsSpan(), str1.AsSpan());
            }
        }

        [Benchmark]
        public void StringConcatUsingSpan_ABitOptimized()
        {
            string str2 = "";
            var str1Span = str1.AsSpan();
            for (int i = 0; i < 1000; i++)
            {
                str2 = String.Concat(str2.AsSpan(), str1Span);
            }
        }
    }
}
