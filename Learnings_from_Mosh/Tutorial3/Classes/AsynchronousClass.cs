using System;
using System.Threading;
using System.Threading.Tasks;

namespace Classes
{
        public class AsynchronousClass
        {
            public async Task DisplayAsync()
            {
            Console.WriteLine("Async Method Started...");
            await Task.Delay(3000);
            Console.WriteLine("Async Method Stopped...");
            }
            
            public void DisplayNormal()
        {
            Console.WriteLine("Normal Method Started...");
            Thread.Sleep(3000);
            Console.WriteLine("Normal Method Stopped...");
        }

    }
    }

