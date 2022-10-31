using MoreCSharp.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Executables
{
    internal class LambdaDemo
    {
        static void Main(string[] n)
        {
            int[] a = { 3, 435, 34, 3, 45, 34, 634, 4, 34, 34, 5634, 34, 34 };
            int[] b = { 34, 3534, 343, 43 };
            ArrayProcessor lengthPrinter = (x) => x.Length;
            ArrayProcessor sumPrinter = (x) =>
            {
                int sum = 0;
                foreach (var temp in x)
                    sum += temp;
                return sum;
            };
            ArrayProcessor maxFinder = (x) =>
            {
                int largest = x[0];
                for (int a = 1; a < x.Length; a++)
                {
                    largest = x[a] > largest ? x[a] : largest;
                }
                return largest;
            };

            Console.WriteLine("Length of a is -> {0}",lengthPrinter(a));
            Console.WriteLine("Sum of elements in a is {0}", sumPrinter(a));
            Console.WriteLine("Sum of elements in b is {0}", sumPrinter(b));
            Console.WriteLine("Max of elements in a is {0}", maxFinder(a));
            Console.WriteLine("Max of elements in b is {0}", maxFinder(b));

        }
    }
}
