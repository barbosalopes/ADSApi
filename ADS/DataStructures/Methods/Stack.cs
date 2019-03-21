using ADSApi.DataStructures.Item;

namespace ConsoleApplication6.Methods
{
    public class Stack <Type>
    {
        private Item<Type> Top;

        public Stack() 
        {
            Top = null;
        }

        public void Push(Type value)
        {
            Item<Type> Item = new Item<Type>(value);
            if (Top == null)
                Top = Item;
            else
            {
                Item.Next = Top;
                Top = Item;
            }
        }

        public object Pop()
        {
            if (Top == null)
                return null;
            else
            {
                Item<Type> aux = Top;
                Top = aux.Next;
                aux.Next = null;
                return aux.Value;
            }
        }

        public object Peek()
        {
            return Top;
        }
    }
}
