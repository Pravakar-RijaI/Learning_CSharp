using System;

namespace Classes
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending Mail...");
        }
    }
}
