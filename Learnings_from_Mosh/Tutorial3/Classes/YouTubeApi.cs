using System;
using System.Collections.Generic;

namespace Classes
{
    public class YouTubeApi
    {
        public List<Video> GetVideo(string user)
		{
			try
			{
				throw new Exception("Some Error Occurred.");
			}
			catch (Exception ex)
			{
				throw new YouTubeException("Fetching Error", ex);
			}
			return new List<Video>();
		}

	}
}
