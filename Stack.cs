using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.Item;

namespace ConsoleApplication6.Methods
{
    public class Stack <Type>
    {
        private StackItem<Type> Top;

        public Stack() 
        {
            Top = null;
        }

        public void Push(Type value)
        {
            StackItem<Type> Item = new StackItem<Type>(value);
            if (Top == null)
                Top = Item;
            else
            {
                Item.Next = Top;
                Top = Item;
            }
        }

        public Type Pop()
        {
            if (Top == null)
                return default(Type);
            else
            {
                StackItem<Type> aux = Top;
                Top = aux.Next;
                aux.Next = null;
                return aux.Data;
            }
        }
    }
}
