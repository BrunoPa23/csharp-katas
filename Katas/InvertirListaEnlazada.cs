namespace Katas;

/// <summary>
/// Nodo propio de una lista simplemente enlazada.
/// </summary>
public class NodoLista<T>(T valor)
{
    public T Valor { get; set; } = valor;
    public NodoLista<T>? Siguiente { get; set; }
}

/// <summary>
/// Kata InvertirListaEnlazada: invierte el orden de los nodos de una lista simplemente
/// enlazada, reacomodando los punteros "Siguiente" sin usar estructuras auxiliares.
/// Complejidad: O(n) en tiempo (un recorrido), O(1) en espacio adicional.
/// </summary>
public static class InvertirListaEnlazada
{
    public static NodoLista<T>? Invertir<T>(NodoLista<T>? cabeza)
    {
        NodoLista<T>? anterior = null;
        NodoLista<T>? actual = cabeza;

        while (actual is not null)
        {
            NodoLista<T>? siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        return anterior;
    }

    public static NodoLista<T>? DesdeArreglo<T>(T[] valores)
    {
        NodoLista<T>? cabeza = null;
        NodoLista<T>? ultimo = null;

        foreach (T valor in valores)
        {
            var nodo = new NodoLista<T>(valor);

            if (cabeza is null)
            {
                cabeza = nodo;
            }
            else
            {
                ultimo!.Siguiente = nodo;
            }

            ultimo = nodo;
        }

        return cabeza;
    }

    public static List<T> AArreglo<T>(NodoLista<T>? cabeza)
    {
        var resultado = new List<T>();
        NodoLista<T>? actual = cabeza;

        while (actual is not null)
        {
            resultado.Add(actual.Valor);
            actual = actual.Siguiente;
        }

        return resultado;
    }
}
