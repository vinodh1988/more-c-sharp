using MoreCSharp.Entity;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace MoreCSharp.CollectionExecutables
{
    internal class DictionaryDemo
    {
        static void Main(string[] n) {
            Employee e1, e2, e3, e4;
            
            e1=new Employee() { Sno = 4, Name = "Praveen", City = "Chennai" };
            e2=new Employee() { Sno = 1, Name = "Naveen", City = "Mumbai" };
            e3=new Employee() { Sno = 3, Name = "Jay", City = "Jaipur" };
            e4=new Employee() { Sno = 2, Name = "Harry", City = "Chennai" };

            Dictionary<int, Employee> d = new Dictionary<int, Employee>();
            d.Add(1, e1);
            d.Add(2, e2);
            d.Add(3, e3);
            d.Add(4, e4);
            d.Add(5, e1);
            d.Add(6, null);
           // d.Add(null, e4);
            //d.Add(3, e4);
            Employee e;
            foreach (var x in d.Keys)
            {
                d.TryGetValue(x, out e);
                String result = e == null ? "IT is null" : e.ToString();
                Console.WriteLine(result);
            }
        }
    }
}
