using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace MoreCSharp.CollectionExecutables
{
    internal class SortedListDemo
    {
        /* 
         * 
         * SortedList is same as Dictionary
         * the only added feature is it is sorted based
         *  on the  keys
         *  and hence the key class should have implementation
         *  of IComparable
         * */

        static void Main(string[] n) { 
            SortedList<int,String> map=new SortedList<int, string> ();
            map.Add(3, "Raj");
            map.Add(4, null);
            map.Add(1, "Christopher");
            map.Add(5, "Arnold");
            map.Add(8, "Joseph");
            map.Add(7, " Null");
            foreach (var x in map) {
                Console.WriteLine("{0}- >{1}", x.Key, x.Value);
            }
        }
    }
}
