using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    class Pair<TFirst, TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }
        public Pair(TFirst first, TSecond second) => (First, Second) = (first,second);
    }
}
