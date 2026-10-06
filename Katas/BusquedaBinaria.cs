namespace Katas;

/// <summary>
/// Kata BusquedaBinaria: busca un valor dentro de un arreglo ordenado dividiendo
/// repetidamente el rango de busqueda a la mitad.
/// Complejidad: O(log n) en tiempo, O(1) en espacio (version iterativa).
/// Devuelve el indice del valor si existe, o -1 si no se encuentra.
/// </summary>
public static class BusquedaBinaria
{
    public static int Buscar(int[] numerosOrdenados, int objetivo)
    {
        int izquierda = 0;
        int derecha = numerosOrdenados.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = izquierda + (derecha - izquierda) / 2;

            if (numerosOrdenados[medio] == objetivo)
            {
                return medio;
            }

            if (numerosOrdenados[medio] < objetivo)
            {
                izquierda = medio + 1;
            }
            else
            {
                derecha = medio - 1;
            }
        }

        return -1;
    }
}
