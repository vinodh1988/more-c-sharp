using MoreCSharp.Generics;
using System;
using System.Collections;
using System.Linq;

namespace MoreCSharp.CollectionExecutables
{
    internal class PriorityBased
    {
        static void Main(string[] b)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Raju");
            stack.Push(true);
            stack.Push(new Store(5));
            stack.Push(new Stack());

            Console.WriteLine(stack);
            foreach(var item in stack)
                Console.WriteLine(item);
            stack.Pop();
            stack.Pop();

            foreach (var item in stack)
                Console.WriteLine(item);

            Queue queue= new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue("Roger");
            queue.Enqueue("Christopher");

            foreach (var item in queue) {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine("right now {0}", queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
