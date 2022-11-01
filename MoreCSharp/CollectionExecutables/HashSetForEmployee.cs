using MoreCSharp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.CollectionExecutables
{
    internal class HashSetForEmployee
    {
        static void Main(string[] s) {
            HashSet<Employee> set = new HashSet<Employee>();
            set.Add(new Employee() { Sno = 4,Name = "Praveen",City = "Chennai"});
            set.Add(new Employee() { Sno = 1, Name = "Naveen", City = "Mumbai" });
            set.Add(new Employee() { Sno = 3, Name = "Jay", City = "Jaipur" });
            set.Add(new Employee() { Sno = 2, Name = "Harry", City = "Chennai" });

            foreach (var x in set)
                Console.WriteLine(x);
        }
    }
}