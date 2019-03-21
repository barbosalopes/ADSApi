using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.Item
{
    public class StackItem<Type> : QueueItem<Type>
    {
        public StackItem<Type> Next { set; get; }

        public StackItem(Type data) : base(data)
        {
            Next = null;
        }
    }
}
