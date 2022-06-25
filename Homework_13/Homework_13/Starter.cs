using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    internal class Starter
    {
        public void Go()
        {
            var result = Do();
            Console.WriteLine(result.Result);
        }

        public async Task<string> ReadHello()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Timur\Desktop\A-lavel\Homework\13\Homework_13\Homework_13\txt\Hello.txt"))
            {
                await Task.Delay(1000);
                return reader.ReadLine();
            }
        }

        public async Task<string> ReadWorld()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Timur\Desktop\A-lavel\Homework\13\Homework_13\Homework_13\txt\World.txt"))
            {
                await Task.Delay(1000);
                return reader.ReadLine();
            }
        }

        public async Task<string> Do()
        {
            Task<string> first;
            Task<string> second;
            await Task.Delay(1000);
            Task.WaitAll(first = ReadHello(), second = ReadWorld());
            return first.Result + second.Result;
        }
    }
}
