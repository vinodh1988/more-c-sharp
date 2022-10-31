using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.AdditionalConcepts
{
    
    internal static class FunctionsHolder
    {
        
        public static void GoForIt() {
            Console.WriteLine("This class has a method and The name is Go For it"); 
        }

        public static void NewMethod(this InstanceMethodHolder holder) {
            Console.WriteLine("This is new Method added to InstanceMethodHolder class");
            Console.WriteLine(holder.instance);
        }

      
    }
}
