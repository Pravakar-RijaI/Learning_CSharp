using System;

namespace Classes
{
    public class SendNotification
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending Notification..");
        }
    }
}
