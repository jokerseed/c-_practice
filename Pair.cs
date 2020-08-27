using System.Collections.Generic;

namespace c
{
    public class Pair<T, Y>
    {
        public T Name;
        public Y Nick;

        public Pair(T name, Y nick)
        {
            this.Name = name;
            this.Nick = nick;
        }
    }
}