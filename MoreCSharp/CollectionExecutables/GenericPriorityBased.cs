using MoreCSharp.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.CollectionExecutables
{
    internal class GenericPriorityBased
    {
        static void Main(string[] q) {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }
    }
}
