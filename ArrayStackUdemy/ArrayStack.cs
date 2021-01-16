using System;

namespace ArrayStackUdemy
{
    public class ArrayStack<T>
    {
        private T[] _stack;
        private int _top;

        public ArrayStack(int capacity)
        {
            _stack = new T[capacity];
        }

        public void Push(T obj)
        {
            if (_top == _stack.Length)
            {
                // Need to resize the backing array
                T[] newArray = new T[2 * _stack.Length];
                Array.Copy(_stack, 0, newArray, 0, _stack.Length);
                _stack = newArray;

            }
            _stack[_top++] = obj;
      
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            T value = _stack[--_top];
            _stack[_top] = default;
            return value;

        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            return _stack[_top - 1];

        }
        public int Size()
        {
            return _top;
        }
        public bool IsEmpty()
        {
            return _top == 0;
        }
        public void PrintStack()
        {
            for (int i = _top - 1; i >= 0; i--)
            {
                Console.WriteLine("Index: " + i  + " - "+  _stack[i]);
            }
        }
    }
}
