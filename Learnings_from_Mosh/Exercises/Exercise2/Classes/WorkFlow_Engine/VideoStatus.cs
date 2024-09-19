using System;

namespace Classes
{
    public class VideoStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video Database Status: Processing");
        }
    }
}
