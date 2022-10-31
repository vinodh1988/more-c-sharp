using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Delegates
{
    internal class Feature
    {
        public static void FeatureProcessing(Callback cb) {
            Console.WriteLine("Function Started 30% of the logic processed by FeatureProcessing");
            cb("Star");
            Console.WriteLine("Last 40% of the logic Continued");
        }
    }
}
