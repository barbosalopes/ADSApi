using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.Item
{
    public class DoubleReferencedItem<Type>  : QueueItem<Type>
    {
        private QueueItem<Type> Previous { set; get; }

        public DoubleReferencedItem(Type value) : base(value)
        {
            Previous = null;
        }
    }
}
