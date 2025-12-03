using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class Program
    {

        static bool IsOpenBracket(char c)
        {
            return c == '(' || c == '[';
        }

        static char OpenBracket(char c)
        {
            if (c == ')')
                return '(';
            return '[';
        }

        static void Main()
        {
            var s = "[()]";
            var stack = new Stack<char>();
            bool error = false;
            foreach (var i in s)
            {
                if (IsOpenBracket(i))
                {
                    stack.Push(i);
                    continue;
                }
                if (stack.Count > 0 && OpenBracket(i) == stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    error = true;
                    break;
                } 
            }
            Console.Write(error || stack.Count > 0 ? "NO" : "YES");
            Console.ReadLine();
        }
    }
}