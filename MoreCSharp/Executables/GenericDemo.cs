using MoreCSharp.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Executables
{
    internal class GenericDemo
    {
        static void Main(string[] x) {
            SuperStore<string> s = new SuperStore<string>("Roger");
            //  s.SetData(24); error
            SuperStore<int> s1 = new SuperStore<int>(34);
            s.Show();
            s1.Show();
        }
    }
}
