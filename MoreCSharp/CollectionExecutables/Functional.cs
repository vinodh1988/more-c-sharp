using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MoreCSharp.CollectionExecutables
{
    internal class Functional
    {
        public static Boolean StartWithA(string a) {
            return a.StartsWith('A');
        }
        static void Main(string[] n)
        {

            Predicate<string> fun = new Predicate<string>(StartWithA);
            Predicate<string> fun2 = delegate(string sample) {
                return sample.EndsWith("n");
            };
            Predicate<string> fun3 = (string n) => n.Length > 5;

            Action<string> action = (x) =>
            {
                Console.WriteLine("Processing : {0} Beautifully", x);
            };

            Console.WriteLine("Whether Anand Starts with A: {0}", fun("Anand"));
            Console.WriteLine("Whether Nanda Starts with A: {0}", fun("Nanda"));
            Console.WriteLine("Whether Kareem Starts with A: {0}", fun("Kareem"));
            Console.WriteLine("Whether Naveen Ends with n: {0}",fun2("Naveen"));
            Console.WriteLine("Whether Joseph has more than 5 characters: {0} ",fun3("Joseph"));

            action("Roger");
        }
    }
    /*
     *   Predicate is an in-built delegate 
     *   
     *   signature of Predicate a function with 1 input(generic type)
     *   and the return value should be boolean
     */
}
