using ADSApi.DataStructures.Item;
using ADSApi.DataStructures.Methods;

namespace ADSApi.DataStructures
{
    public class DoubleReferencedQueue <Type> : Queue<Type>
    {
        private DoubleReferencedItem<Type> First, Last, Aux;

        public DoubleReferencedQueue(Type value)
        {
            First = Last = null;
        }

        public override void Insert(Type value)
        {
            Aux = new DoubleReferencedItem<Type>(value);
            if (IsEmpty())
                First = Last = Aux;
            else
            {
                Last.Next = Aux;
                Aux.Previous = Last;
                Last = Aux;
            }
        }

        public override object Remove(Type value)
        {
            if (IsEmpty()) return null;
            else
            {
                Aux = First;
                while(Aux != null)
                {
                    if (Aux.Value.Equals(value)) return value;
                    Aux = Aux.Next;
                }
                return null;
            }
        }

    }
}
