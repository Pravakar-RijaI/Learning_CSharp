using System;
using System.Reflection;
using System.Security.Policy;

namespace StackOverPost
{
    internal class Post
    {
        public string Title {get; set;}
        public string Description { get; set;}
        public DateTime CreatedOn { get; set;}
        private int Count = 0;
        
        public void UpVote()
        {
            Count++;
        }
        
        public void DownVote()
        {
            Count--;
        }
        
        public int VoteValue { get { return this.Count; } }
    }
}
