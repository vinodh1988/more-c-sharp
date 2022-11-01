using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.CollectionExecutables
{
    internal class HashSetDemo
    {
        static void Main(string[] s) { 
          HashSet<string> set = new HashSet<string>();
            set.Add("Ram");
            set.Add("Ram");
            set.Add(null);
            set.Add("Roger");
            set.Add("Anand");
            set.Add("Nicholas");
            // Console.Write(set[3]);

            foreach (var x in set) { 
                Console.WriteLine(x);
            }
        }
    }

    /* 
     *   List vs Set
     *   
     *   List is ordered
     *   List is indexed
     *   List can have null values
     *   List can have duplicates
     *   random insertion,deletion and access is possible
     *   
     *   
     *   Set has no duplicates
     *   Set is not ordered
     *   only one null is supported
     *   random insert/delete/access not possible as it is
     *   not indexed
     */
}
