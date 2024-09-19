using System;

namespace Classes
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("To: Owner\nSubject: Started Video Processing.\nSending Email...");
        }
    }
}
