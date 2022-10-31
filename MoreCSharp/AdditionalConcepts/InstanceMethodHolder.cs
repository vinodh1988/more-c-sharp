using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MoreCSharp.AdditionalConcepts
{
   
    internal class InstanceMethodHolder
    {
        public int instance;

        public InstanceMethodHolder(int instance)
        {
            this.instance = instance;
        }

        public void InstanceMethod() {
            Console.WriteLine("Instance Method is Working");
        }
    }
}
