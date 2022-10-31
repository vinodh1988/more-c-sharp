using MoreCSharp.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Executables
{
    internal class DelegateDemo
    {
        public static string ProcessedString(StringProcess p,string x) {
            return p(x);
        }

        public static int IntegerProcess(TwoIntegerProcess p, int x, int y)
        {
            return p(x,y);
        }
        static void Main(string[] n) {
            string result1=ProcessedString(new StringProcess(GeneralStatic.SayHi),"Vinay");
            string result2 = ProcessedString(new StringProcess(GeneralStatic.GreetMore), "Rahul");
            int result3 = IntegerProcess(new TwoIntegerProcess(GeneralStatic.Add), 345, 353);
            int result4 = IntegerProcess(new TwoIntegerProcess(GeneralStatic.Greater), 34, 3455);

            Console.WriteLine(result1 + " " + result2 + " " + result3 + "  " + result4);
        }
    }
}
