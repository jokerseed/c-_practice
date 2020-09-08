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

namespace c
{
    class Program3
    {
        public void Init()
        {
            //任务返回类型有Task  Task<T>  void   valueTask<T>
            // Console.WriteLine(GetUrlContentLengthAsync());
            // Console.WriteLine("programe--init--end");

            CancellationTokenSource c = new CancellationTokenSource();
            var token = c.Token;
            Task t = Task.Run(async () =>
              {
                  Console.WriteLine(await GetUrlContentLengthAsync());
              }, token);
            // c.Cancel();
            // t.Wait();
            // Console.WriteLine("wait--------");
        }

        //带有返回值的异步方法
        public async Task<int> GetUrlContentLengthAsync()
        {
            Console.WriteLine("GetUrlContentLengthAsync--------");
            var client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com/dotnet");
            string contents = await getStringTask;
            return contents.Length;
        }
    }
}
