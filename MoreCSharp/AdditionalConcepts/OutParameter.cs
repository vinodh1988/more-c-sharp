using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.AdditionalConcepts
{
    internal static class OutParameter
    {
        public static void SumOfElemenetsInArray(int[] n, out int result) {

            result = 0;
            foreach (var x in n) {
                result += x;
            }
           
        }
    }
}
