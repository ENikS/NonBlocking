using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace Benchmarks
{
    public class Add
    {
        IDictionary<int, string> NonBlocking;
        IDictionary<int, string> Concurrent;
        IDictionary<int, string> Experimental;

        [IterationSetup]
        public void Setup()
        {
            NonBlocking = new NonBlocking.ConcurrentDictionary<int, string>();
            Concurrent = new System.Collections.Concurrent.ConcurrentDictionary<int, string>(1, 8);
            Experimental = new Experimental.ConcurrentDictionary<int, string>(); 
        }

        [Benchmark]
        public void Concurrent_1()
        {
            Concurrent.Add(0, "0");
        }

        [Benchmark]
        public void NonBlocking_1()
        {
            NonBlocking.Add(0, "0");
        }

        [Benchmark]
        public void Experimental_1()
        {
            Experimental.Add(0, "0");
        }


        [Benchmark]
        public void Concurrent_2()
        {
            Concurrent.Add(0, "0");
            Concurrent.Add(1, "1");
        }

        [Benchmark]
        public void NonBlocking_2()
        {
            NonBlocking.Add(0, "0");
            NonBlocking.Add(1, "1");
        }

        [Benchmark]
        public void Experimental_2()
        {
            Experimental.Add(0, "0");
            Experimental.Add(1, "1");
        }

        [Benchmark]
        public void Concurrent_4()
        {
            Concurrent.Add(0, "0");
            Concurrent.Add(1, "1");
            Concurrent.Add(2, "2");
            Concurrent.Add(3, "3");
        }

        [Benchmark]
        public void NonBlocking_4()
        {
            NonBlocking.Add(0, "0");
            NonBlocking.Add(1, "1");
            NonBlocking.Add(2, "2");
            NonBlocking.Add(3, "3");
        }

        [Benchmark]
        public void Experimental_4()
        {
            Experimental.Add(0, "0");
            Experimental.Add(1, "1");
            Experimental.Add(2, "2");
            Experimental.Add(3, "3");
        }

        [Benchmark]
        public void Concurrent_6()
        {
            Concurrent.Add(0, "0");
            Concurrent.Add(1, "1");
            Concurrent.Add(2, "2");
            Concurrent.Add(3, "3");
            Concurrent.Add(4, "4");
            Concurrent.Add(5, "5");
        }

        [Benchmark]
        public void NonBlocking_6()
        {
            NonBlocking.Add(0, "0");
            NonBlocking.Add(1, "1");
            NonBlocking.Add(2, "2");
            NonBlocking.Add(3, "3");
            NonBlocking.Add(4, "4");
            NonBlocking.Add(5, "5");
        }

        [Benchmark]
        public void Experimental_6()
        {
            Experimental.Add(0, "0");
            Experimental.Add(1, "1");
            Experimental.Add(2, "2");
            Experimental.Add(3, "3");
            Experimental.Add(4, "4");
            Experimental.Add(5, "5");
        }


        [Benchmark]
        public void Concurrent_8()
        {
            Concurrent.Add(0, "0");
            Concurrent.Add(1, "1");
            Concurrent.Add(2, "2");
            Concurrent.Add(3, "3");
            Concurrent.Add(4, "4");
            Concurrent.Add(5, "5");
            Concurrent.Add(6, "6");
            Concurrent.Add(7, "7");
        }

        [Benchmark]
        public void NonBlocking_8()
        {
            NonBlocking.Add(0, "0");
            NonBlocking.Add(1, "1");
            NonBlocking.Add(2, "2");
            NonBlocking.Add(3, "3");
            NonBlocking.Add(4, "4");
            NonBlocking.Add(5, "5");
            NonBlocking.Add(6, "6");
            NonBlocking.Add(7, "7");
        }

        [Benchmark]
        public void Experimental_8()
        {
            Experimental.Add(0, "0");
            Experimental.Add(1, "1");
            Experimental.Add(2, "2");
            Experimental.Add(3, "3");
            Experimental.Add(4, "4");
            Experimental.Add(5, "5");
            Experimental.Add(6, "6");
            Experimental.Add(7, "7");
        }

        [Benchmark]
        public void Concurrent_10()
        {
            Concurrent.Add(0, "0");
            Concurrent.Add(1, "1");
            Concurrent.Add(2, "2");
            Concurrent.Add(3, "3");
            Concurrent.Add(4, "4");
            Concurrent.Add(5, "5");
            Concurrent.Add(6, "6");
            Concurrent.Add(7, "7");
            Concurrent.Add(8, "8");
            Concurrent.Add(9, "9");
        }

        [Benchmark]
        public void NonBlocking_10()
        {
            NonBlocking.Add(0, "0");
            NonBlocking.Add(1, "1");
            NonBlocking.Add(2, "2");
            NonBlocking.Add(3, "3");
            NonBlocking.Add(4, "4");
            NonBlocking.Add(5, "5");
            NonBlocking.Add(6, "6");
            NonBlocking.Add(7, "7");
            NonBlocking.Add(8, "8");
            NonBlocking.Add(9, "9");
        }

        [Benchmark]
        public void Experimental_10()
        {
            Experimental.Add(0, "0");
            Experimental.Add(1, "1");
            Experimental.Add(2, "2");
            Experimental.Add(3, "3");
            Experimental.Add(4, "4");
            Experimental.Add(5, "5");
            Experimental.Add(6, "6");
            Experimental.Add(7, "7");
            Experimental.Add(8, "8");
            Experimental.Add(9, "9");
        }

        [Benchmark]
        public void Concurrent_20()
        {
            Concurrent.Add(0, "0");
            Concurrent.Add(1, "1");
            Concurrent.Add(2, "2");
            Concurrent.Add(3, "3");
            Concurrent.Add(4, "4");
            Concurrent.Add(5, "5");
            Concurrent.Add(6, "6");
            Concurrent.Add(7, "7");
            Concurrent.Add(8, "8");
            Concurrent.Add(9, "9");
            Concurrent.Add(10, "10");
            Concurrent.Add(11, "11");
            Concurrent.Add(12, "12");
            Concurrent.Add(13, "13");
            Concurrent.Add(14, "14");
            Concurrent.Add(15, "15");
            Concurrent.Add(16, "16");
            Concurrent.Add(17, "17");
            Concurrent.Add(18, "18");
            Concurrent.Add(19, "19");
        }

        [Benchmark]
        public void NonBlocking_20()
        {
            NonBlocking.Add(0, "0");
            NonBlocking.Add(1, "1");
            NonBlocking.Add(2, "2");
            NonBlocking.Add(3, "3");
            NonBlocking.Add(4, "4");
            NonBlocking.Add(5, "5");
            NonBlocking.Add(6, "6");
            NonBlocking.Add(7, "7");
            NonBlocking.Add(8, "8");
            NonBlocking.Add(9, "9");
            NonBlocking.Add(10, "10");
            NonBlocking.Add(11, "11");
            NonBlocking.Add(12, "12");
            NonBlocking.Add(13, "13");
            NonBlocking.Add(14, "14");
            NonBlocking.Add(15, "15");
            NonBlocking.Add(16, "16");
            NonBlocking.Add(17, "17");
            NonBlocking.Add(18, "18");
            NonBlocking.Add(19, "19");
        }

        [Benchmark]
        public void Experimental_20()
        {
            Experimental.Add(0, "0");
            Experimental.Add(1, "1");
            Experimental.Add(2, "2");
            Experimental.Add(3, "3");
            Experimental.Add(4, "4");
            Experimental.Add(5, "5");
            Experimental.Add(6, "6");
            Experimental.Add(7, "7");
            Experimental.Add(8, "8");
            Experimental.Add(9, "9");
            Experimental.Add(10, "10");
            Experimental.Add(11, "11");
            Experimental.Add(12, "12");
            Experimental.Add(13, "13");
            Experimental.Add(14, "14");
            Experimental.Add(15, "15");
            Experimental.Add(16, "16");
            Experimental.Add(17, "17");
            Experimental.Add(18, "18");
            Experimental.Add(19, "19");
        }
    }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.