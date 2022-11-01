using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MoreCSharp.Entity
{
    internal class Employee :IComparable<Employee>
    {
        public int Sno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public int CompareTo([AllowNull] Employee other)
        {
            if (Sno == other.Sno)
                return 0;
            if (Sno > other.Sno)
                return 1;
            else
                return -1;
        }

       public override string ToString()
        {

            return "{ Sno:" + Sno + " ,Name: " + Name + ", City: " + City + " }";
        }
    }
}
