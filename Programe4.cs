using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Timers;
using System.Net.Http;
using System.Diagnostics;
using System.Threading;
using System.Collections;

namespace c
{
    class Program4
    {
        public void Init()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d["one"] = 10;
            d["two"] = 110;
            d["three"] = 1110;
            d["four"] = 11110;
            d["five"] = 111110;

            //队列
            Queue<int> q = new Queue<int>();

            //栈
            Stack<int> s = new Stack<int>();

            //按键排序的键值对
            SortedList<int, int> sl = new SortedList<int, int>();

            ArrayList l = new ArrayList();
            l.Add(10);
            l.Add(11);
            l.Add(12);
            l.Add("dasda");
        }
    }
}
