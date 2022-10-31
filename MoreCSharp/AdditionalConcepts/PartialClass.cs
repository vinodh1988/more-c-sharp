using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.AdditionalConcepts
{

    partial class Window
    {
        public void Event1()
        {
            Console.WriteLine("One Part of the Window Event 1 is handled");
        }
    }

    partial class Window
    {
        public void Event2() {
            Console.WriteLine("Second Part of the class handling Event2");
        }
    }
}