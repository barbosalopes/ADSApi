using ADSApi.DataStructures.Item;

namespace ADSApi.DataStructures.Methods
{
    public class Queue <Type>
    {
        private Item<Type> First, Last, Aux;

        public Queue()
        {
            First = Last = null;
        }

        public int Size()
        {
            if (First == null) return 0;
            else
            {
                int size = 1;
                Aux = First;
                while (Aux != null)
                {
                    size++;
                    Aux = Aux.Next;
                }
                return size;
            }
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public virtual void Insert(Type value)
        {
            Aux = new Item<Type>(value);
            if (IsEmpty())
                First = Last = Aux;
            else
            {
                Last.Next = Aux;
                Last = Aux;
            }
        }

        public virtual object Remove(Type value)
        {
            if (IsEmpty()) return null;
            else
            {
                return null;   
            }
        }

        public Type Find(Type value)
        {
            Item<Type> aux = First;
            while (aux.Next != null)
            {
                if (aux.Value.Equals(value)) return aux.Value;
                aux = aux.Next;
            }

            return default(Type);
        }
    }
}
