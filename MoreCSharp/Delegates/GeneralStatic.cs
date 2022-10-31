using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MoreCSharp.Delegates
{
    internal class GeneralStatic
    {
        public static string SayHi(String name) {
            return "Hi! " + name;
        }

        public static string GreetMore(string str) {
            return "Welcome!" + str;
        }

        public static int Add(int a, int b)
        {
           return a + b;
        }

        public static int Greater(int a,int b) {
            return a > b ? a : b;
        }
    }
}
