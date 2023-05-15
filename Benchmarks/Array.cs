using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace Benchmarks
{
    public class ArrayTests
    {
        int[][] TwoDimentionalArray;
        int[]   SimpleArray;


        [IterationSetup]
        public void Setup()
        {
            TwoDimentionalArray = new int[100][];
            for (int i = 0; i < 100; i++) 
            {
                TwoDimentionalArray[i] = new int[100];
                for (int j = 0; j < 100; j++)
                    TwoDimentionalArray[i][j] = i * 10 + j;
            }

            SimpleArray = new int[1000];
            for (int i = 0; i < 1000; i++)
                SimpleArray[i] = i;

        }

        [Params(1, 20, 30, 40, 50, 60, 70, 80)]
        public int N;


        [Benchmark]
        public int SimpleArrayTest()
        {
            int a = 0;
            for (int s = 0; s < 1111; s++)
            {
                for (int i = 0; i < N; i++)
                    a += SimpleArray[i];
            }
                
            return a;
        }

        [Benchmark]
        public int TwoDimentionalArrayTest()
        {
            int a = 0;

            for (int s = 0; s < 1111; s++)
            {
                for (int i = 0; i < N; i++)
                    a += TwoDimentionalArray[i][i];
            }

            return a;

        }
    }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.