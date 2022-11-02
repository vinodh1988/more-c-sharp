using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.AdditionalConcepts
{
    internal static class PassByReference
    {

        public static void ChangeIt(ref int a, ref int b) {
            Console.WriteLine("Original A:{0}, B:{1}", a, b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("A:{0}, B:{1}", a, b);
        }
    }
}
