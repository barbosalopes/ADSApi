using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSApi.DataStructures.Item
{
    public class DoubleReferencedItem<Type> 
    {
        public DoubleReferencedItem<Type> Previous { set; get; }
        public DoubleReferencedItem<Type> Next { set; get; }
        public Type Value { set; get; }

        public DoubleReferencedItem(Type value)
        {
            Next = Previous = null;
        }
    }
}
