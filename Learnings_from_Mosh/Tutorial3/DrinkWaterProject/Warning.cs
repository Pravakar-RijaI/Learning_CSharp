using System;
using System.Text;

namespace DrinkWaterProject
{
    public class Warning
    {
        public void OnWarningLevel(object source, EventArgs args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            Console.WriteLine(stringBuilder
                .Append('!',5)
                .Append(" Warning ",0,9)
                .Append('!',5)
                .AppendLine("\n\n..Water Already On Warning Level..\n")
                .AppendLine("...Please Fill Water..."));
        }
    }
}
