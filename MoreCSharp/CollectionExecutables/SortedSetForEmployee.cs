using MoreCSharp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.CollectionExecutables
{
    internal class SortedSetForEmployee
    {
        static void Main(string[] n) {
           SortedSet<Employee> set = new SortedSet<Employee>();
            set.Add(new Employee() { Sno = 4, Name = "Praveen", City = "Chennai" });
            set.Add(new Employee() { Sno = 1, Name = "Naveen", City = "Mumbai" });
            set.Add(new Employee() { Sno = 3, Name = "Jay", City = "Jaipur" });
            set.Add(new Employee() { Sno = 2, Name = "Harry", City = "Chennai" });
            Employee a = new Employee()
            {
                Sno = 5,
                Name = "Rajeev",
                City = "Chennai"
            };
            set.Add(a);

            Console.WriteLine(set.Contains(new Employee() { Sno = 1, Name = "Naveen", City = "Mumbai" }));
            foreach (var x in set)
                Console.WriteLine(x);

        }
    }
}
