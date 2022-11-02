using MoreCSharp.AdditionalConcepts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.MoreExecutables
{
    internal class OutDemo
    {
        static void Main(string[] n) {
            int x=90;
            int[] a = { 34, 34, 353, 343, 534, 356, 34, 36, 3356 };

            OutParameter.SumOfElemenetsInArray(a, out x);

            Console.WriteLine("Sum of the elements in the array:{0}",x);
        }
    }
}
