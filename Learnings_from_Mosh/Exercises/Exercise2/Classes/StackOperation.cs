using System;
using System.Collections;
using System.Linq.Expressions;

namespace Classes
{
    internal class Stack
    {
        private int _top = -1;
        private readonly ArrayList StackOp = new ArrayList();

        public void Push (object obj)
        {
            try 
            {   if (obj != null)
                {
                    _top++;
                    StackOp.Add(obj);
                }
                else
                    throw new NullReferenceException();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null Reference: " + e.Message);
            }
        }
        
        public object Pop ()
        {
            if (!(_top == -1))
            {
                object item = StackOp[_top];
                StackOp.RemoveAt(_top);
                _top--;
                return item;
            }
            else
                throw new InvalidOperationException();
        }

        public void Clear ()
        {
            StackOp.Clear();
            _top = -1;
        }
    }
}
