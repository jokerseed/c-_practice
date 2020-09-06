using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace c
{
    class Program
    {
        public delegate int d1(int a);

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //穿插值
            // string a = "猪";
            // Console.WriteLine($"我是大帅{a}");

            //取出空格
            // string greeting = "      Hello World!       ";
            // Console.WriteLine($"[{greeting}]");

            // string trimmedGreeting = greeting.TrimStart();
            // Console.WriteLine($"[{trimmedGreeting}]");

            // trimmedGreeting = greeting.TrimEnd();
            // Console.WriteLine($"[{trimmedGreeting}]");

            // trimmedGreeting = greeting.Trim();
            // Console.WriteLine($"[{trimmedGreeting}]");

            //字符串替换   字符串全大写和全小写
            // string sayHello = "Hello World!";
            // Console.WriteLine(sayHello);
            // sayHello = sayHello.Replace("Hello", "Greetings");
            // Console.WriteLine(sayHello);

            // Console.WriteLine(sayHello.ToUpper() + "-----" + sayHello.ToLower());

            //字符串中是否包含子串   字符串是否以某一子串开头或结尾
            // string songLyrics = "You say goodbye, and I say hello";
            // Console.WriteLine(songLyrics.Contains("goodbye"));
            // Console.WriteLine(songLyrics.Contains("greetings"));

            // Console.WriteLine(songLyrics.StartsWith("You"));
            // Console.WriteLine(songLyrics.EndsWith("hello"));

            //双精度浮点数范围
            // Console.WriteLine(double.MaxValue + "~" + double.MinValue);

            // double third = 1.0 / 3.0;
            // Console.WriteLine(third);

            //十进制数
            // Console.WriteLine(decimal.MinValue + "~" + decimal.MaxValue);
            // double a = 1.0;
            // double b = 3.0;
            // Console.WriteLine(a / b);

            // decimal c = 1.0M;
            // decimal d = 3.0M;
            // Console.WriteLine(c / d);

            // double radius = 2.50;
            // double area = Math.PI * radius * radius;
            // Console.WriteLine(area);

            //List遍历
            // var names = new List<string> { "<name>", "Ana", "Felipe" };
            // foreach (var name in names)
            // {
            //     Console.WriteLine($"Hello {name.ToUpper()}!");
            // }

            // names.ForEach((a) =>
            // {
            //     Console.WriteLine(a);
            // });

            // var t = new List<int>() { 1, 2, 3 };
            // Console.WriteLine(t[1]);

            // names.Add("qwe");
            // names.Remove("Ana");

            // throw 语句将引发异常。 当前块执行结束，将控制权移交给在调用堆栈中发现的第一个匹配的 catch 块。 添加 catch 块可以稍后再测试一下此代码。
            // try
            // {
            //     throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine(e.ToString());
            // }

            //使用stringBuilder
            // var report = new StringBuilder();
            // report.AppendLine("Date\t\tAmount\tBalance\tNote");
            // Console.WriteLine(report.ToString());

            // Person p = new Person("神经病");
            // Console.WriteLine(p.Name);
            // Console.WriteLine(p.ToString());

            //平均子串长度
            // var phrase = "the quick brown fox jumps over the lazy dog";
            // var wordLength = from word in phrase.Split(' ') select word.Length;
            // var average = wordLength.Average();
            // Console.WriteLine(average);

            // string s = null;
            // char? c = s?[0];
            // Console.WriteLine(c.HasValue);
            // Console.Write(nameof(s));

            // var startingDeck = from s in Suits()
            //                    from r in Ranks()
            //                    select new { Suit = s, Rank = r };

            // // Display each card that we've generated and placed in startingDeck in the console
            // foreach (var card in startingDeck)
            // {
            //     Console.WriteLine(card);
            // }

            //反射
            // Console.WriteLine(typeof(Person));
            // Console.WriteLine(typeof(Person).GetTypeInfo());
            // Console.WriteLine(typeof(Person).GetTypeInfo().GetCustomAttributes());
            // Console.WriteLine(typeof(Person).GetFields());
            // Person p = new Person("xx");
            // Console.WriteLine(p);
            // Console.WriteLine(p.GetType());
            // Console.WriteLine(p.GetType().GetTypeInfo().GetCustomAttributes());
            // Console.WriteLine(p.GetType().GetProperties());
            // Console.WriteLine(p.GetType().GetFields());


            // var t = p.GetType().GetTypeInfo().GetCustomAttributes();
            // foreach (var temp in t)
            // {
            //     System.Console.WriteLine(temp);
            // }

            // var list = new List<int>();
            // list.Add(1);

            // list.Add(1);
            // list.Add(1);
            // list.Add(1);

            // list.Add(1);
            // list.Add(1);
            // list.Add(1);
            // list.Add(1);
            // list.ForEach(f => System.Console.WriteLine(f));

            //泛形
            // Pair<string, string> p = new Pair<string, string>("xx", "yy");
            // Console.WriteLine(p.Name + "  " + p.Nick);

            // MyList<string> my = new MyList<string>();
            // my.Changed += new EventHandler(ListChanged);
            // my.Add("sss");
            // my.Add("sss");
            // my.Add("sss");

            //委托
            // d1 d = cc;
            // Console.WriteLine(d(1));
            // Action<int> ac = ccc;
            // ac(2);


            Program2 p = new Program2();
            p.Init();

            Console.ReadLine();
        }
        public static void ccc(int ccc)
        {
            Console.WriteLine(ccc);
        }
        public static int cc(int ccc)
        {
            return ccc;
        }

        public static void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("list--changed");
        }

        [Flags]
        public enum StateType
        {
            on,
            off
        }

        interface IC
        {
            void c();
        }

        interface IB
        {
            void b();
        }

        interface IA : IC, IB
        {
            void a();
        }

        // public struct Point
        // {
        //     public int x;
        //     public int y;
        //     public int z;
        // }

        // Program.cs
        // The Main() method

        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
