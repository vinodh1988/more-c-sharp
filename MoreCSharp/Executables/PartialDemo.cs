using MoreCSharp.AdditionalConcepts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MoreCSharp.Executables
{
    internal class PartialDemo
    {
        static void Main(string[] n) {
            Window window = new Window();
            window.Event1();
            window.Event2();
        } 
    }
}
