using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Generics
{
    internal class SuperStore<T>
    {
        T data;

        public SuperStore(T data)
            
        {
            this.data = data;
        }

        public void SetData(T data)
        {
            this.data = data;
        }
        public void Show()
        {
            Console.WriteLine("Data is {0}", data);
        }
    }
}
