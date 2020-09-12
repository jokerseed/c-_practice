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
using System.Linq.Expressions;

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

            // foreach (KeyValuePair<string, int> item in d)
            // {
            //     Console.WriteLine(item.Key);
            //     Console.WriteLine(item.Value);
            // }

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

            List<Car> li = new List<Car> {
                new Car(411),
                new Car(11241),
                new Car(1123),
                new Car(112),
                new Car(11)
             };
            li.Sort();
            // foreach (var temp in li)
            // {
            //     Console.WriteLine(temp.A);
            // }


            //--------------表达式树
            // Add the following using directive to your code file:  
            // using System.Linq.Expressions;  

            // Create an expression tree.  
            Expression<Func<int, bool>> exprTree = num => num < 5;

            ParameterExpression param = (ParameterExpression)exprTree.Parameters[0];
            BinaryExpression operation = (BinaryExpression)exprTree.Body;
            ParameterExpression left = (ParameterExpression)operation.Left;
            ConstantExpression right = (ConstantExpression)operation.Right;

            // Console.WriteLine("Decomposed expression: {0} => {1} {2} {3}",
            //                   param.Name, left.Name, operation.NodeType, right.Value);
        }
    }
}
