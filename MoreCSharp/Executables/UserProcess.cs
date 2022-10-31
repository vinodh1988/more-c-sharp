using MoreCSharp.Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Executables
{
    internal class UserProcess
    {
        public static void UserLogic(string n) {
            Console.WriteLine("User logic started");
            Console.WriteLine("userProcessed " + n);
        }
        static void Main(string[] n) {
            Feature.FeatureProcessing(new Callback(UserLogic));
        }
    }
}
