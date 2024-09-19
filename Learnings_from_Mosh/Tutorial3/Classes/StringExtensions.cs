using System;
using System.Linq;

namespace Extensions
{
    public static class StringExtensions
        {
            public static string Summary(this string str, int numberofwords)
            {
            if (numberofwords < 0)
                throw new ArgumentOutOfRangeException("Invalid Number of Words.");
            
            var words = str.Split(' ');

            if (!(words.Length < numberofwords))
            {
                return string.Join(" ", words.Take(numberofwords))+"...";
            }

            return str + "...";
            }
        }
}
