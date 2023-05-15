using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ENiks
{
    public class Miscelaneous
    {
        [DebuggerDisplay("Hash: {_hash}, Name: {_name}")]
        class S1
        {
            private string _name;
            private int _hash;

            public string Name { get => _name; set => _name = value; }

            public S1(int x, string name)
            {
                _hash = x;
                Name = name;
            }

            public override string ToString()
            {
                return _hash.ToString();
            }

            public override int GetHashCode()
            {
                return _hash;
            }

            public class Comparer : IEqualityComparer<S1>
            {
                bool IEqualityComparer<S1>.Equals(S1 x, S1 y)
                {
                    return x == y;
                }

                int IEqualityComparer<S1>.GetHashCode(S1 obj)
                {
                    return obj._hash;
                }
            }
        }

        [Fact()]
        public static void AddTwoCD()
        {
            var dict = new System.Collections.Concurrent.ConcurrentDictionary<S1, string>(new S1.Comparer());

            var s1 = new S1(1, 1.ToString());
            var s2 = new S1(1, 2.ToString());

            dict.TryAdd(s1, s1.Name);
            dict.TryAdd(s2, s2.Name);

            Assert.Equal(2, dict.Count);

            Assert.True(dict.ContainsKey(s1));
            Assert.True(dict.ContainsKey(s2));

            Assert.Equal(1, s1.GetHashCode());
            Assert.Equal(1, s2.GetHashCode());
        }

        [Fact()]
        public static void AddTwoNB()
        {
            var dict = new Experimental.ConcurrentDictionary<S1, string>(new S1.Comparer());

            var s1 = new S1(1, 1.ToString());
            var s2 = new S1(1, 2.ToString());

            dict.TryAdd(s1, s1.Name);
            dict.TryAdd(s2, s2.Name);

            Assert.Equal(2, dict.Count);

            Assert.True(dict.ContainsKey(s1));
            Assert.True(dict.ContainsKey(s2));

            Assert.Equal(1, s1.GetHashCode());
            Assert.Equal(1, s2.GetHashCode());
        }

        [Fact()]
        public static void AddTwoHundred()
        {
            var dict = new Experimental.ConcurrentDictionary<S1, string>(new S1.Comparer());

            for (int i = 0; i < 1000; i++)
            { 
                var s1 = new S1(i, i.ToString());
            
                dict.TryAdd(s1, s1.Name);
            }

            Assert.Equal(1000, dict.Count);
        }
    }
}
