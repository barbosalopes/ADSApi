using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.Item
{
    public class Item <Type>
    {
        public Type Data { set; get; }

        public Item(Type data)
        {
            this.Data = data;
        }

        public override bool Equals(object obj)
        {
            return Data.Equals((Type)obj);
        }
    }
}
