using MoreCSharp.AdditionalConcepts;
using MoreCSharp.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Executables
{
    internal class StoreExecutor
    {
        static void Main(string[] x) {
            Store s = new Store(30);
            Store s1 = new Store("Roger");
            Store s3 = new Store(new InstanceMethodHolder(23));

            s.Show();
            s.SetData("Rahul");
            s.Show();
            s1.Show();
            s3.Show();
        }
    }
}
