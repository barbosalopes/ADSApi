using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.Item
{
    public class QueueItem <Type> : Item <Type>
    {
        public QueueItem<Type> Next { set; get; }
        
        public QueueItem(Type data) : base(data)
        {
            Next = null;
        }

    }
}
