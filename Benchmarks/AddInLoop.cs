using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace Benchmarks
{
    public class AddInLoop
    {
        IDictionary<int, string> NonBlocking;
        IDictionary<int, string> Concurrent;
        IDictionary<int, string> Experimental;

        [IterationSetup]
        public void Setup()
        {
            NonBlocking = new NonBlocking.ConcurrentDictionary<int, string>();
            Concurrent = new System.Collections.Concurrent.ConcurrentDictionary<int, string>();
            Experimental = new Experimental.ConcurrentDictionary<int, string>();
        }

        [Params(1, 10, 100, 1_000, 10_000)]
        public int N;

        [Benchmark]
        public void Add_Concurrent()
        {
            for(int i = 0; i < N; i++) 
                Concurrent.Add(i, "Concurrent");
        }

        [Benchmark]
        public void Add_NonBlocking()
        {
            for (int i = 0; i < N; i++)
                NonBlocking.Add(i, "NonBlocking");
        }

        [Benchmark]
        public void Add_Experimental()
        {
            for (int i = 0; i < N; i++)
                Experimental.Add(i, "NonBlocking");
        }
    }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.