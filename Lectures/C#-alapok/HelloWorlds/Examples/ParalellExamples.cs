using System;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    class ParalellExamples
    {
        public void StartThread()
        {
            var thread = new Thread(ThreadCode);
            thread.Start();
            thread.Join();
        }

        public void ThreadCode()
        {
            while (true)
            {
                // ...
            }
        }

        public void TaskTest()
        {
            var task = Task.Factory.StartNew(() =>
            {
                // ...
            });
        }

        public void ThreadPoolTest()
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
                // ...
            });
        }

        public async void DoAsync()
        {
            var task = Task.Factory.StartNew(ThreadCode);

            await task;

            Console.WriteLine(task.Status);
        }
    }
}
