using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.Item;

namespace ConsoleApplication6.Methods
{
    public class Queue <Type>
    {
        private Item.QueueItem<Type> Sentinel;
        private Item.QueueItem<Type> First, Last;

        public Queue()
        {
            Sentinel = new Item.QueueItem<Type>(default(Type));
        }

        public void Add(Type value)
        {
            Item.QueueItem<Type> Item = new Item.QueueItem<Type>(value);
            Last.Next = Item;
            Last = Item;
        }

        public Type Remove()
        {
            if(First.Next == null)
            {
                return default(Type);
            } 
            else
            {
                Item.QueueItem<Type> aux = First.Next;
                First.Next = aux.Next;
                return aux.Data;
            }
        }

        public Type Find(Type value)
        {
            Item.QueueItem<Type> aux = First;
            while(aux.Next != null)
            {
                if (aux.Data.Equals(value)) return aux.Data;
                aux = aux.Next;
            }

            return default(Type);
        }
    }
}
