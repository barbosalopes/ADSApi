using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSApi.DataStructures.Item
{
    public class Item<Type>
    {
        public Type Value { set; get; }

        public Item<Type> Next { set; get; }

        public Item(Type value)
        {
            Value = value;
            Next = null;
        }

        public override bool Equals(object obj)
        {
            return Value.Equals((Type)obj);
        }
    }
}
