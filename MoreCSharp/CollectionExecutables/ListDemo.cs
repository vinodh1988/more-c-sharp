using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MoreCSharp.CollectionExecutables
{
    internal class ListDemo
    {
        static void Main(string[] n)
        {
            List<string> list = new List<string>();
            list.Add("roger") ;
            list.Add("Ravi");
            list.Add("roger");
            list.Add(null);
            list.Add(null);
            Console.WriteLine(list.Contains("Ravi"));
            Console.WriteLine(list.LastIndexOf("Ravi"));
            list.Insert(3, "Nixon");
            Console.WriteLine(list[3]);
            // list.Remove("Ravi");
           
            list.RemoveAt(3);

            foreach (var x in list)
                Console.Write(x + "-> ");

            Console.WriteLine("length is {0}", list.Count);
        }
    }
}
