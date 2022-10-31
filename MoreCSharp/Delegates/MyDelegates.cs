using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Delegates
{
    //this is a delegate which represents a function 
    // which has string as return type and one string parameter
    delegate string StringProcess(string n);
    delegate int TwoIntegerProcess(int a, int b);
    delegate void Callback(string n);
}
