using MoreCSharp.AdditionalConcepts;
using MoreCSharp.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.MoreExecutables
{
    internal class RefDemo
    {
        static void Main(string[] n) {
            int a = 30, b = 20;
            PassByReference.ChangeIt(ref a,b);
            Console.WriteLine("In main Class: a:{0}, b:{1}", a, b);
        }
    }
}
