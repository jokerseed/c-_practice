using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Timers;
using System.Net.Http;

namespace c
{
    class Program3
    {
        public void Init()
        {
            Console.WriteLine(GetUrlContentLengthAsync());
            Console.WriteLine("programe--init--end");
        }

        //带有返回值的异步方法
        public async Task<int> GetUrlContentLengthAsync()
        {
            var client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com/dotnet");
            string contents = await getStringTask;
            return contents.Length;
        }
    }
}
