using System;

namespace Classes
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerexception)
            :base(message,innerexception)
        {

        }
    }
}
