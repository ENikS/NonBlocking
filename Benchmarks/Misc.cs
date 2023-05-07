using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{
    public class Misc
    {
        Action<int, int> action = (_, __) => { };

        [Benchmark]
        public void EmptyAction() => action(0, 0);


        [Benchmark]
        public void EmptyActionInvoke() => action.Invoke(0, 0);
    }
}
