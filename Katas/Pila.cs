namespace Katas;

/// <summary>
/// Kata Pila generica: implementacion propia de una estructura LIFO (ultimo en entrar,
/// primero en salir) usando una lista interna como almacenamiento.
/// Complejidad: Push, Pop, Peek y Count son O(1) en tiempo (amortizado para Push por
/// el crecimiento interno de List&lt;T&gt;). Espacio O(n) segun la cantidad de elementos.
/// </summary>
public class Pila<T>
{
    private readonly List<T> _elementos = [];

    public int Count => _elementos.Count;

    public void Push(T elemento)
    {
        _elementos.Add(elemento);
    }

    public T Pop()
    {
        if (_elementos.Count == 0)
        {
            throw new InvalidOperationException("No se puede hacer Pop de una pila vacia");
        }

        int ultimoIndice = _elementos.Count - 1;
        T elemento = _elementos[ultimoIndice];
        _elementos.RemoveAt(ultimoIndice);

        return elemento;
    }

    public T Peek()
    {
        if (_elementos.Count == 0)
        {
            throw new InvalidOperationException("No se puede hacer Peek de una pila vacia");
        }

        return _elementos[^1];
    }
}
