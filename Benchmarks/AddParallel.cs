using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace Benchmarks
{
    public class AddParallel
    {
        IDictionary<int, int> NonBlocking;
        IDictionary<int, int> Concurrent;
        IDictionary<int, int> Experimental;

        [IterationSetup]
        public void Setup()
        {
            Concurrent   = new System.Collections.Concurrent.ConcurrentDictionary<int, int>();
            NonBlocking  = new NonBlocking.ConcurrentDictionary<int, int>();
            Experimental = new Experimental.ConcurrentDictionary<int, int>();
        }

        [Params(10, 100, 1_000, 10_000, 100_000, 1_000_000)]
        public int N;

        [Benchmark]
        public void Add_Concurrent()
        {
            Parallel.For(0, N, (i) => Concurrent.Add(i, i));
        }

        [Benchmark]
        public void Add_NonBlocking()
        {
            Parallel.For(0, N, (i) => NonBlocking.Add(i, i));
        }

        [Benchmark]
        public void Add_Experimental()
        {
            Parallel.For(0, N, (i) => Experimental.Add(i, i));
        }
    }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.