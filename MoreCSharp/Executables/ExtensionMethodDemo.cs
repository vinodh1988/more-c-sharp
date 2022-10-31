using MoreCSharp.AdditionalConcepts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Executables
{
    internal class ExtensionMethodDemo
    {
        static void Main(string[] n) {
            InstanceMethodHolder i = new InstanceMethodHolder(30);
            i.InstanceMethod();
            i.NewMethod();
             i = new InstanceMethodHolder(90);
            i.InstanceMethod();
            i.NewMethod();
        }
    }
}
