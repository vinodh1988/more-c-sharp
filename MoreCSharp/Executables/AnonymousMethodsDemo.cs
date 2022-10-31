using MoreCSharp.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Executables
{
    internal class AnonymousMethodsDemo
    {
        public static string UpperReturn(String x) {
            return x.ToUpper();
        }
        static void Main(string[] n) {
            StringProcess s = new StringProcess(UpperReturn);
            Console.WriteLine(s("india"));

            StringProcess s1 = delegate (string x)
            {
                return "Hey!!!" + x;
            }; //anonymous function

            Console.WriteLine(s1("Joseph"));

            StringProcess s2 = (x) => "Hello!" + x;//lambda function

            Console.WriteLine(s2("James "));
        }
    }
}
