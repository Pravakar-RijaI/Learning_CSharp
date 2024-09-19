using System;

namespace Composition
{
    internal class Logger
    {
        public void LoggMessage(string message)
        {
            Console.WriteLine(message + "Logging the Appropriate.");
        } 
    }
}
