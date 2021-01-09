using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new LIFO(10);
           
            for (int i = 0; i < 10; i++)
            {
                Task.Run(() =>
                {
                    PushAndGet(stack);
                });
            }
            Thread.Sleep(1500);
            Console.WriteLine(stack.Count());

            Console.ReadLine();
        }
        private static void PushAndGet(LIFO stack)
        {
            for (int i = 0; i < stack.Length; i++)
            {
                stack.Push(i);
                //stack.Get();
                Console.WriteLine("fdscdsvdsvsdvs");
            }

            Console.WriteLine("finish");
        }
    }
}
