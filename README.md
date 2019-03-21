# ADSApi

Exercício 5

a)
```C#
// Pesquisa binária
public int alg5(int[] a, int x) {
    int low = 0;
    int high = a.length - 1;
    /*
    Melhor caso: 1 (tamanho do array 0)
    Pior caso: (LogN + 2 (Teste e transposição dos dados))
     */
    while (low <= high) {
        // +1
        int mid = (low + high)/2;
        // +1
        if (a[mid] == x) return mid;
        // +1
        else if (a[mid] < x) low = mid + 1;
        else high = mid - 1;
    }
    return -1;
}

Atividade de lab:

Filas com leitos especificos (UTI, internação, enfermaria) com o passar do tempo ele melhora e vai para outro leito. 

        public void Insert(Type value)
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

        public object Remove(Type value)
        {
            if (IsEmpty()) return null;
            else
            {
                Aux = First;
                while (Aux != null)
                {
                    if (Aux.Value.Equals(value)) return value;
                    Aux = Aux.Next;
                }

                return null;
            }
        }
