using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.CollectionExecutables
{
    internal class SortedSet
    {
        static void Main(string[] n) {
            SortedSet<string> l = new SortedSet<string>();
            l.Add("Peterson");
            l.Add("Nicholas");
            l.Add("Arun");
            l.Add("Naresh");
            l.Add("Baskar");
            l.Add("Bose");
            l.Add(null);

            foreach (var x in l)
                Console.WriteLine(x);
        } 
    } 

    /*
     * Same as Hashset but elements are sorted
     * 
     */
}
