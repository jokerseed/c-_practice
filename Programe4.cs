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
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    };

    enum Player
    {
        name,
        age
    }

    class Program4
    {
        public Player c = Player.age;

        public void test()
        {
            Books books;
            books.title = "sss";
            books.author = "aaa";
            books.subject = "cccc";
            books.book_id = 1;

            if (books.book_id == Convert.ToInt32(Player.age))
            {
                Console.WriteLine("测试");
            }
        }

        public void Init()
        {
            test();

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

            // test(1, 2, 234, 23, 252);

            Console.WriteLine(getIndex(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5));

        }

        void test(params int[] a)
        {
            if (a != null && a.Length > 0)
            {
                foreach (int v in a)
                {
                    Console.WriteLine(v);
                }
                return;
            }
            Console.WriteLine("没有参数");
        }

        //二分查找
        int getIndex(int[] a, int n)
        {
            int max = a.Length - 1;
            int min = 0;
            int index = 0;
            while (min != max)
            {
                int temp = (min + max) / 2;
                if (a[temp] > n)
                {
                    max = temp;
                }
                else if (a[temp] < n)
                {
                    min = temp;
                }
                else
                {
                    max = min;
                    index = temp;
                }
            }
            return index;
        }
    }
}
