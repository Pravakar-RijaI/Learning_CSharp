using System;
using System.Diagnostics.CodeAnalysis;

namespace Classes
{
    public class Generics<T> where T : struct
    {
        private T _data;
        public Generics(T data)
        {
            this._data = data;
        }
        public void Display()
        {
        Console.WriteLine("Operand is {0}",_data);
        }
    }

    public class Generica
    {
        public T Diss<T>(T data)
        {
            return data;
        }
    }
}
