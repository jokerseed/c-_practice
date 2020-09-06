using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Timers;

namespace c
{
    class Program2
    {
        public void Init()
        {
            // await test();
            // Console.WriteLine("完成");

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;  //true 定时器会重复执行   false   只会执行一次
            timer.Elapsed += (sender, e) =>
            {
                // Console.WriteLine("Tiemr End");
                // timer.Enabled = false;
                // timer = null;
                update();
            };
            timer.Enabled = true;

            Console.WriteLine("测试阻塞");
        }

        private void update()
        {
            Console.WriteLine(DateTime.UtcNow);
        }

        public async Task test()
        {
            Console.WriteLine("Delay Start");
            await Task.Delay(2000);
            Console.WriteLine("Delay END");
        }
    }
}
