using ADSApi.DataStructures.Item;

namespace ADSApi.DataStructures.Methods
{
    public class Queue <Type>
    {
        private Item<Type> First, Last;

        public Queue()
        {
            First = Last = null;
        }

        public int Size()
        {
            if (First == null) return 0;
            else
            {
                int size = 0;
                Item<Type> Aux = First;
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
            Item<Type> Aux = new Item<Type>(value);
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
                Item<Type> Aux = First;
                if (Aux.Value.Equals(value))
                {
                    First = Aux.Next;
                    Aux.Next = null;
                    return value;
                }
                do
                {
                    if(Aux.Next.Value.Equals(value))
                    {
                        Item<Type> ValueToReturn = Aux.Next;
                        ValueToReturn.Next = null;
                        Aux.Next = Aux.Next.Next;
                    }
                } while (Aux.Next!=null);

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

        public Type[] ToArray()
        {
            Type[] toReturn = new Type[Size()];
            Item<Type> aux = First;
            int i = 0;

            while (aux != null)
            {
                toReturn[i] = aux.Value;
                i++;
                aux = aux.Next;
            }

            return toReturn;
        }
    }
}
