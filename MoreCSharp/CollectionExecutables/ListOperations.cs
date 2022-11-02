using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.CollectionExecutables
{
    internal class ListOperations
    {
        static void Main(string[] n) {
            List<String> list = new List<String>(n);

            list.ForEach(x =>
            {
                Console.WriteLine("length of {0} is {1}", x, x.Length);
            });

            if (list.Exists(x => x.Contains("ram")))
            {
                Console.WriteLine("Yes Exists");
            }
            else {
                Console.WriteLine("Not Exists");
            }

           
           Console.WriteLine("FoundMatch:{0}", list.Find(x => x.Contains("ram")));

            foreach (var x in list.FindAll(x => !x.Contains("ram")))
                Console.WriteLine("FoundMatch without ram:{0}", x);
        }
    }
}
