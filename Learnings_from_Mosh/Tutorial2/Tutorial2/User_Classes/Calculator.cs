using System;
using System.Data.SqlTypes;

namespace Calculate
{
    internal class Calculator
    {
        public void Add(out int Sum,params int[] numbers)
        {
            Sum = 0;
            foreach(int number in numbers)
            {
                Sum += number;
            }
        }
    }
}
