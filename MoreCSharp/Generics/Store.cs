using System;
using System.Collections.Generic;
using System.Text;

namespace MoreCSharp.Generics
{
    internal class Store
    {
        private object data;

        public Store(object data) {
            this.data = data;
        }

        public void SetData(object data)
        {
            this.data = data;
        }
        public void Show() {
            Console.WriteLine("Data is {0}", data);
        }
    }
}
