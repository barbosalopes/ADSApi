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
