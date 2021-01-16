using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayStackUdemy
{
    public class LinkedStack<T>
    {
        private LinkedList<T> _stack;
        
        public LinkedStack()
        {
            _stack = new LinkedList<T>();
        }

        public void Push(T obj)
        {
            _stack.AddFirst(obj);
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            T obj = _stack.First();
            _stack.Remove(obj);
            return obj;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            T obj = _stack.First();
            return obj;
        }
        public bool IsEmpty()
        {
            return _stack.Count < 1;
        }
        public void PrintStack()
        {
            foreach (var item in _stack)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string jane = "Jane";
            //string john = "John";
            //string Mary = "Mary";
            //string Mike = "Mike";
            //string bill = "Bill";

            //ArrayStack<string> stack = new ArrayStack<string>(10);

            //stack.Push(jane);
            //stack.Push(john);
            //stack.Push(Mary);
            //stack.Push(Mike);
            //stack.Push(bill);


            //stack.PrintStack();
            //Console.WriteLine();

            //Console.WriteLine(stack.Size());
            //Console.WriteLine("Peek: " + stack.Peek());
            //Console.WriteLine("Popped: " + stack.Pop());
            //Console.WriteLine("Peek: " + stack.Peek());

            //Console.WriteLine();
            //stack.PrintStack();



            //string jane = "Jane";
            //string john = "John";
            //string Mary = "Mary";
            //string Mike = "Mike";
            //string bill = "Bill";

            //LinkedStack<string> stack = new LinkedStack<string>();

            //stack.Push(jane);
            //stack.Push(john);
            //stack.Push(Mary);
            //stack.Push(Mike);
            //stack.Push(bill);


            //stack.PrintStack();
            //Console.WriteLine();

            //Console.WriteLine("Peek: " + stack.Peek());
            //Console.WriteLine("Popped: " + stack.Pop());
            //Console.WriteLine("Peek: " + stack.Peek());

            //Console.WriteLine();
            //stack.PrintStack();



            Console.WriteLine(IsPalindrome("abccba")); // true
            Console.WriteLine(IsPalindrome("Was it a car or a cat I saw?"));// true
            Console.WriteLine(IsPalindrome("I did, did I?"));// true
            Console.WriteLine(IsPalindrome("hello")); // false
            Console.WriteLine(IsPalindrome("Don't nod")); // true

            Console.ReadLine();
        }
        public static bool IsPalindrome(string value)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder stringNoPunctuation = new StringBuilder(value.Length);
            char[] lowerCase = value.ToLower().ToCharArray();

            foreach (var c in lowerCase)
            {
                if (c >= 'a' && c <= 'z')
                {
                    stringNoPunctuation.Append(c);
                    stack.Push(c);
                }
            }

            StringBuilder reversedString = new StringBuilder(stack.Count);
            while (stack.Count > 0)
            {
                reversedString.Append(stack.Pop());
            }

            return reversedString.ToString() == stringNoPunctuation.ToString();
        }
    }
}
